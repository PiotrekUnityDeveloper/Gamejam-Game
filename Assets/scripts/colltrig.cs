using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colltrig : MonoBehaviour
{
    public playerfollow pf_script;
    public GameObject player;

    public GameObject currentguard;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("ludzik");
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
                

                if(eventscr.issneaking == true && (Vector2.Distance(player.transform.position, currentguard.transform.position) > 4.6f))
                {

                }
                else
                {
                    pf_script.canfollow = true;
                    eventscr.pausemain();
                }

            }
            else
            {

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

                if (eventscr2.issneaking == true && (Vector2.Distance(player.transform.position, currentguard.transform.position) <= 4.6f))
                {
                    eventscr2.pausemain();
                }
                else if(eventscr2.issneaking == false)
                {
                    eventscr2.pausemain();
                }
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

            

            if (evcode.issneaking == true && (Vector2.Distance(player.transform.position, currentguard.transform.position) > 4.6f))
            {
                evcode.stopchasemusic();
            }
            else if(evcode.issneaking == true)
            {
                evcode.stopchasemusic();
            }

        }
    }
}
