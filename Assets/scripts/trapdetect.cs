using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapdetect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            events evv = GameObject.Find("EventSystem").GetComponent<events>();
            evv.activatetrap(1);
            Destroy(this.gameObject);
        }
    }
}
