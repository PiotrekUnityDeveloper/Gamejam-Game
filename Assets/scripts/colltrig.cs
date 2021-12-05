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
            pf_script.canfollow = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            pf_script.canfollow = false;
        }
    }
}
