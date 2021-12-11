using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchhurt : MonoBehaviour
{
    public bool ccanhurt = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(hurtingprocess());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        if(collision.tag == "Player")
        {
            ccanhurt = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        

        if(collision.tag == "Player")
        {
            ccanhurt = false;
        }
    }

    public IEnumerator hurtingprocess()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        if(ccanhurt == true)
        {
            events er = GameObject.Find("EventSystem").GetComponent<events>();
            er.damageplayer();
            er.playdmgsound();
            

            
        }

        StartCoroutine(hurtingprocess());
    }
}
