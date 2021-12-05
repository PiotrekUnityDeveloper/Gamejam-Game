using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrsoundgen : MonoBehaviour
{
    public AudioSource asrc;

    public AudioSource asrc2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //nothing here
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            asrc.Play();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            asrc2.Play();
        }
    }
}
