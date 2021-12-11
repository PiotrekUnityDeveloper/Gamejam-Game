using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchdie : MonoBehaviour
{
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
        events et = GameObject.Find("EventSystem").GetComponent<events>();
        

        if(collision.tag == "Player")
        {
            et.gameover(1);
        }
    }
}
