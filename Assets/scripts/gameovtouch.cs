using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameovtouch : MonoBehaviour
{
    public bool canhurt = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(damageplr());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            events ew = GameObject.Find("EventSystem").GetComponent<events>();
            //ew.gameover(2);
            canhurt = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        canhurt = false;
    }

    public IEnumerator damageplr()
    {
        yield return new WaitForSeconds(0.5f);
        events ew2 = GameObject.Find("EventSystem").GetComponent<events>();
        
        if(canhurt == true)
        {
            ew2.damageplayer();
            ew2.playdmgsound();
        }

        StartCoroutine(damageplr());
    }
}
