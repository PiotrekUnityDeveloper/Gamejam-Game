using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colltrig : MonoBehaviour
{
    public playerfollow pf_script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            
            events eventscr = GameObject.Find("EventSystem").GetComponent<events>();
            if(eventscr.haveguardsuit == false)
            {
                pf_script.canfollow = true;
                eventscr.pausemain();
            }
            
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            events eventscr2 = GameObject.Find("EventSystem").GetComponent<events>();
            if(eventscr2.chasetrack.isPlaying == false)
            {
                eventscr2.pausemain();
            }
        }
    }

    public GameObject playerobj01;
    public events evcode;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            pf_script.canfollow = false;
            //events eventscr001 = GameObject.Find("EventSystem").GetComponent<events>();

            if (isActiveAndEnabled /*&& GameObject.Find("EventSystem") != null /*&& playerobj01 != null && eventscr001.isdead == false*/)
            {
                //events eventscr = GameObject.Find("EventSystem").GetComponent<events>(); //error highlight this line
                evcode.stopchasemusic();
            }
            
        }
    }
}
