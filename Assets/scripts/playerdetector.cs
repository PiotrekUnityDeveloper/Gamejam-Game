using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerdetector : MonoBehaviour
{
    public GameObject gameoverscreen;
    public int soundid;
    public bool trigger_gameover;

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
            //triggers gameover() or not depending on inspector settings

            if(trigger_gameover == true)
            {
                events ev = GameObject.Find("EventSystem").GetComponent<events>();
                ev.gameover(soundid);

                if (ev.haveguardsuit == false)
                {
                    //yes
                    

                }
            }
        }

    }
}
