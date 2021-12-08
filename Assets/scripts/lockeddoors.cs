using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockeddoors : MonoBehaviour
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
        if(collision.tag == "Player")
        {
            events eee = GameObject.Find("EventSystem").GetComponent<events>();
            eee.sendcameratext("LOCKED", Color.white, 1.5f);
        }
    }
}
