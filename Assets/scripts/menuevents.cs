using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuevents : MonoBehaviour
{
    public AudioSource volsrc;
    public Slider vol;

    //preview sources
    public AudioSource mainmusic01;
    public AudioSource chasemusic01;

    public AudioSource menutrack;

    public GameObject helppanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void volumechanged()
    {
        volsrc.volume = vol.value;
        volsrc.Play();

        PlayerPrefs.SetFloat("mainvolume", vol.value);
    }

    public void showhelppanel()
    {
        helppanel.SetActive(true);
    }

    public void hidehelppanel()
    {
        helppanel.SetActive(false);
    }

    public GameObject helppanel2;

    public void helppanelpage(int page)
    {
        if(page == 1)
        {
            helppanel.SetActive(true);
            helppanel2.SetActive(false);
        }
        else
        {
            helppanel2.SetActive(true);
            helppanel.SetActive(false);
        }
    }

    public void playmaintrack()
    {
        mainmusic01.Play();
        menutrack.Pause();
    }

    public void playchasetrack()
    {
        chasemusic01.Play();
        menutrack.Pause();
    }

    public void stopallpreviewtracks()
    {
        mainmusic01.Stop();
        chasemusic01.Stop();
        menutrack.UnPause();
    }

    public AudioSource clicksound;

    public void soundonclick()
    {
        clicksound.Play();
    }

    public void RAGEQUIT()
    {
        //UnityEditor.EditorUtility.DisplayDialog("RAGE QUIT", "KEEP CALM AND RAGE QUIT", "YES", "YES");
        //UnityEditor.EditorUtility.DisplayDialog("RAGE QUIT", "KEEP CALM AND RAGE QUIT", "YES", "YES");
        //UnityEditor.EditorUtility.DisplayDialog("RAGE QUIT", "KEEP CALM AND RAGE QUIT", "YES", "YES");
        //UnityEditor.EditorUtility.DisplayDialog("RAGE QUIT", "KEEP CALM AND RAGE QUIT", "YES", "YES");
        Application.Quit();
    }

    public void exitgame()
    {
        Application.Quit();
    }

    //main menu panels code

    public GameObject play;
    public GameObject options;
    public GameObject credits;
    public GameObject h2p;
    public GameObject exit;

    public void showplay()
    {
        play.SetActive(true);
        options.SetActive(false);
        credits.SetActive(false);
        h2p.SetActive(false);
        exit.SetActive(false);
    }

    public void showoptions()
    {
        play.SetActive(false);
        options.SetActive(true);
        credits.SetActive(false);
        h2p.SetActive(false);
        exit.SetActive(false);
    }

    public void showcredits()
    {
        play.SetActive(false);
        options.SetActive(false);
        credits.SetActive(true);
        h2p.SetActive(false);
        exit.SetActive(false);
    }

    public void showh2p()
    {
        play.SetActive(false);
        options.SetActive(false);
        credits.SetActive(false);
        h2p.SetActive(true);
        exit.SetActive(false);
    }

    public void showexit()
    {
        play.SetActive(false);
        options.SetActive(false);
        credits.SetActive(false);
        h2p.SetActive(false);
        exit.SetActive(true);
    }

    public void FixedUpdate()
    {
        
    }

    public Toggle redovertoggle;

    public void updatehardcoremode()
    {
        

        if(redovertoggle.isOn == true)
        {
            PlayerPrefs.SetInt("hardmode", 1);
        }
        else
        {
            PlayerPrefs.SetInt("hardmode", 0);
        }
    }

    public void loadfirstlevel()
    {
        SceneManager.LoadScene("SampleScene");
    }

    
    public GameObject redobj;

    public void togglehardmodeimpact()
    {
        if(redovertoggle.isOn == true)
        {
            redobj.SetActive(true);
        }
        else
        {
            redobj.SetActive(false);
        }
    }

    public void openlink(int linkid)
    {
        
        if(linkid == 1)
        {
            Application.OpenURL("https://www.youtube.com/channel/UCM9q2NDkEB99gAJ8JV0pVNQ/videos");
        }
        else if(linkid == 2)
        {
            Application.OpenURL("https://soundcloud.com/user-193244278");

        }
        else if(linkid == 3)
        {
            Application.OpenURL("https://valentinocervinimusic.itch.io/");
        }
        else if(linkid == 4)
        {
            Application.OpenURL("https://piotrek4.itch.io/");
        }
    }

}
