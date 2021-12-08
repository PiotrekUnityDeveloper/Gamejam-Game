using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dmgplayer : MonoBehaviour
{
    public float bulletspeed;
    public Rigidbody2D rb;

    public Transform firepoint02;
    

    Vector2 mousepos;

    // Start is called before the first frame update
    void Start()
    {
        mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Vector2 lookdirection = mousepos - rb.position;
        float angle = Mathf.Atan2(mousepos.x, mousepos.y) * Mathf.Rad2Deg;
        //rb.rotation = angle;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            events e01 = GameObject.Find("EventSystem").GetComponent<events>();
            e01.playdmgsound();
            e01.damageplayer();
            Destroy(this.gameObject);
        }
        else
        {
            events e02 = GameObject.Find("EventSystem").GetComponent<events>();
            e02.playdestroysound();
            Destroy(this.gameObject);
        }
    }
}
