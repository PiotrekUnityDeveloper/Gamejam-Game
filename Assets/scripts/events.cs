using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class events : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        updateplayersfrictionandbounciness();
        //Physics.gravity = new Vector3(1f, -9.81f, 0f);

        //StartCoroutine(footcooldown());
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

    

    private void Awake()
    {
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

        if(deathcounter > 2)
        {
            hintobj.SetActive(true);
        }
        else
        {
            hintobj.SetActive(false);
        }

        
    }

    public int footstepqueue = 0;

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
        enemyhit01.SetActive(true);
    }
}
