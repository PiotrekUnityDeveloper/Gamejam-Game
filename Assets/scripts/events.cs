using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class events : MonoBehaviour
{
    public GameObject redoverlay;

    public bool haveguardsuit;
    //public bool haveplank;

    public bool isdead = false;

    public float playerhealth = 1;

    // Start is called before the first frame update
    void Start()
    {
        updateplayersfrictionandbounciness();
        //Physics.gravity = new Vector3(1f, -9.81f, 0f);

        //StartCoroutine(footcooldown());

        if(PlayerPrefs.GetInt("hardmode") == 1)
        {
            redoverlay.SetActive(true);
        }
    }

    // Update is called once per frame

    


    public Slider frictionslider;
    public Slider bounceslider;
    public Slider gravslider;
    public Toggle revgravitycheck;

    public Rigidbody2D playerrigid;

    public GameObject PlayerObj;
    public PhysicsMaterial2D physmat;

    public float defaultgravity = 9.81f;

    public Slider movespeedmodifier;

    public GameObject bouncewarning;
    public GameObject frictionwarning;

    public GameObject toohightext;

    public GameObject cooltext;
    public GameObject movewarning;

    public AudioSource footstepssound;
    public AudioSource footstepssound2;

    public int deathcounter;

    public GameObject hintobj;
    public GameObject enemyhit01;

    public GameObject gvol;

    //other AS

    public AudioSource maintheme;
    public AudioSource chasetheme;

    private void Awake()
    {
        //setting up all AudioSources
        footstepssound.volume = PlayerPrefs.GetFloat("mainvolume", 1);
        //footstepssound2.volume = PlayerPrefs.GetFloat("mainvolume", 1);
        maintheme.volume = PlayerPrefs.GetFloat("mainvolume", 1);
        chasetheme.volume = PlayerPrefs.GetFloat("mainvolume", 1);


        //PlayerPrefs.SetInt("enemydeath", 0);

        frictionslider.value = PlayerPrefs.GetFloat("friction", 1);
        bounceslider.value = PlayerPrefs.GetFloat("bounciness", 1);
        gravslider.value = PlayerPrefs.GetFloat("gravity", 0);
        movespeedmodifier.value = PlayerPrefs.GetFloat("movespeed", 0.4f);

        print("loading done!");
        Debug.Log("friction value:" + frictionslider.value + "    playerprefs: " + PlayerPrefs.GetFloat("friction"));
        Debug.Log("bounciness value:" + bounceslider.value + "    playerprefs:" + PlayerPrefs.GetFloat("bounciness"));
        Debug.Log("gravity value:" + gravslider.value + "    playerprefs: " + PlayerPrefs.GetFloat("gravity"));
        Debug.Log("movespeed value:" + movespeedmodifier.value + "    playerprefs: " + PlayerPrefs.GetFloat("movespeed"));

        updateplayersfrictionandbounciness();

        deathcounter = PlayerPrefs.GetInt("deaths", 0);

        if(SceneManager.GetActiveScene().name == "SampleScene")
        {
            if (deathcounter > 2)
            {
                hintobj.SetActive(true);
            }
            else
            {
                hintobj.SetActive(false);
            }
        }

        

        //thats it
    }

    public int footstepqueue = 0;
    public Slider playerhealthdisplayer;

    void Update()
    {

        

        


        
        if(frictionslider.value < 0.9f)
        {
            if(bounceslider.value > 0.35f)
            {
                bouncewarning.SetActive(true);
                //frictionslider.value = 2;
                bounceslider.value = 0.6f;
                updateplayersfrictionandbounciness();
            }
            else
            {
                bouncewarning.SetActive(false);
            }
        }
        else
        {
            bouncewarning.SetActive(false);
        }

        if (bounceslider.value > 0.4f)
        {
            if (frictionslider.value < 0.6f)
            {
                frictionwarning.SetActive(true);
                bounceslider.value = 0f;
                updateplayersfrictionandbounciness();
            }
            else
            {
                frictionwarning.SetActive(false);
            }
        }
        else
        {
            frictionwarning.SetActive(false);
            //bouncewarning.SetActive(false); 
        }

        if(bounceslider.value > 1.6f)
        {
            frictionslider.value = 3f;
            toohightext.SetActive(true);
        }
        else
        {
            toohightext.SetActive(false);
        }

        if(bounceslider.value > 0.1f && frictionslider.value < 0.001f)
        {
            cooltext.SetActive(true);

        }
        else
        {
            cooltext.SetActive(false);
        }

        if(movespeedmodifier.value > 0.3f)
        {
            bounceslider.value = 0f;
            frictionslider.value = 3f;
            movewarning.SetActive(true);
        }
        else
        {
            movewarning.SetActive(false);
        }

        //other stuff

        footstepplayer();


        if (playerhealth < 0 && playerhealth > 1)
        {
            //playerhealthdisplayer.value = playerhealth;
        }
        else
        {
            

            if(SceneManager.GetActiveScene().name == "Level2" /* SceneManager.GetActiveScene().name != "Level1" || SceneManager.GetActiveScene().name != "SampleScene" */)
            {
                playerhealthdisplayer.value = playerhealth;
            }
        }

        //playerhealthdisplayer.value = playerhealth;
    }

    public void backtomainmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void footstepplayer()
    {
        if (playerrigid.velocity.x > 0.1f || playerrigid.velocity.y > 0.1f)
        {
            if(footstepssound.isPlaying == false)
            {

                if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
                {
                    footstepssound.Play();
                }
            }
        }
    }

    public IEnumerator footcooldown()
    {
        if (playerrigid.velocity.x > 0 || playerrigid.velocity.y > 0)
        {
            if(footstepqueue == 0)
            {
                footstepssound.Play();
                footstepqueue = 1;
            }

            if (footstepqueue == 1)
            {
                footstepssound.Play();
                footstepqueue = 0;
            }
        }
        else
        {
            StartCoroutine(footcooldown());
        }

        yield return new WaitForSeconds(1f);
        //StartCoroutine(footcooldown());
    }

    public void updateplayersfrictionandbounciness()
    {
        //PlayerObj.GetComponent<PhysicsMaterial2D>().friction = frictionslider.value;
        PlayerObj.GetComponent<BoxCollider2D>().sharedMaterial.bounciness = bounceslider.value;
        PlayerObj.GetComponent<Rigidbody2D>().drag = frictionslider.value;
        PlayerObj.GetComponent<Rigidbody2D>().angularDrag = frictionslider.value;
        PlayerObj.GetComponent<Rigidbody2D>().gravityScale = gravslider.value;


        //PlayerObj.GetComponent<Collider2D>().enabled = false;
        //PlayerObj.GetComponent<Collider2D>().enabled = true;

        PlayerObj.GetComponent<BoxCollider2D>().enabled = false;
        PlayerObj.GetComponent<BoxCollider2D>().enabled = true;
        PlayerObj.GetComponent<BoxCollider2D>().sharedMaterial = null;
        PlayerObj.GetComponent<BoxCollider2D>().sharedMaterial = physmat;

        PlayerObj.GetComponent<movement>().movespeed = movespeedmodifier.value;
    }

    public void resetgrav()
    {
        gravslider.value = 0;
        updateplayersfrictionandbounciness();
    }

    public void resetmoves()
    {
        PlayerObj.GetComponent<movement>().movespeed = 0.2f;
        movespeedmodifier.value = 0.2f;
        updateplayersfrictionandbounciness();
    }

    public GameObject gameoverpanel;
    public AudioSource dmgsrc;
    public AudioSource dmgsrc2;
    public GameObject player;

    public void gameover(int soundtype)
    {
        isdead = true;

        //savin player settings
        PlayerPrefs.SetFloat("gravity", gravslider.value);
        PlayerPrefs.SetFloat("friction", frictionslider.value);
        PlayerPrefs.SetFloat("bounciness", bounceslider.value);
        PlayerPrefs.SetFloat("movespeed", movespeedmodifier.value);

        //deathcounter += 1;
        PlayerPrefs.SetInt("deaths", (PlayerPrefs.GetInt("deaths", 0) + 1));

        gameoverpanel.SetActive(true);

        
        if(soundtype == 1)
        {
            dmgsrc.Play();
            player.SetActive(false);
        }
        else if(soundtype == 2)
        {
            dmgsrc2.Play();
            player.SetActive(false);
        }
    }

    public void restartgame()
    {
        Scene currentScene = new Scene();
        currentScene = SceneManager.GetActiveScene();

        SceneManager.LoadScene(currentScene.name); //load active scene one time so everything get reset
    }


    public void exitgame()
    {
        PlayerPrefs.SetInt("deaths", 0);
        PlayerPrefs.SetInt("enemydeath", 0);
        PlayerPrefs.SetInt("hardmode", 0);
        Application.Quit();
    }

    

    public void activatetrap(int trapid)
    {
        //Debug.Log("yes?");

        if(trapid == 1)
        {
            movement mv = GameObject.Find("ludzik").GetComponent<movement>();
            movespeedmodifier.value = 0.050f;
            movespeedmodifier.enabled = false;
            updateplayersfrictionandbounciness();
            //mv.movespeed = 0.050f;
            print("well done");

            //yield return new WaitForSeconds(3.8f);
            //mv.movespeed = 0.2f;

            //trapcountdown(1);
            StartCoroutine(trapcountdown(1));
            
        }
        else if(trapid == 2)
        {
            //other trap type (ex. insta-kill (gameover()))
        }

        //yes
    }

    public IEnumerator trapcountdown(int tid)
    {
        yield return new WaitForSeconds(3.8f);

        if(tid == 1)
        {
            movespeedmodifier.value = 0.4f;
            movespeedmodifier.enabled = true;
            updateplayersfrictionandbounciness();
            print("yay it works somehow");
        }
    }

    

    public void enemyhint()
    {
        

        if(SceneManager.GetActiveScene().name == "SampleScene")
        {
            enemyhit01.SetActive(true);
        }
    }

    public AudioSource maintrack;
    public AudioSource chasetrack;

    public void pausemain()
    {
        maintrack.Pause();
        chasetrack.Play();
    }

    public void stopchasemusic()
    {
        chasetrack.Stop();
        maintrack.UnPause();
    }

    public Text infotext;
    public GameObject infotextgobj;

    public void triggercameratext(string text1, Color txtcolor, float distime)
    {
        StartCoroutine(sendcameratext(text1, txtcolor, distime));
    }

    public IEnumerator sendcameratext(string text, Color textcolor, float displaytime)
    {
        infotextgobj.SetActive(true);
        infotext.text = text;
        infotext.color = textcolor;
        yield return new WaitForSecondsRealtime(displaytime);
        infotextgobj.SetActive(false);
    }

    public AudioSource dmg;
    public AudioSource dest;

    public void playdmgsound()
    {
        dmg.Play();
    }

    public void damageplayer()
    {
        playerhealth -= 0.1f;

        if(playerhealth <= 0)
        {
            gameover(1);
        }
    }

    public void playdestroysound()
    {
        dest.Play();
        //YES I KNOW MY CODE PRACTICES ARE BAD DONT JUDGE ME
        //I DIDNT WANT TO WASTE TIME ON SOUND CLASSES AND ALL THAT STUFF
    }
}
