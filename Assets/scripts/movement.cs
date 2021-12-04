using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float movespeed;
    public Rigidbody2D player;

    // Start is called before the first frame update
    void Start()
    {
        //movespeed = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetKey(KeyCode.W))
        {
            this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y + movespeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y - movespeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x + movespeed, this.gameObject.transform.position.y);
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x - movespeed, this.gameObject.transform.position.y);
        }
        */

        /*

        if (Input.GetKey(KeyCode.W))
        {
            player.velocity = new Vector2(player.velocity.x, movespeed);
        }


        if (Input.GetKey(KeyCode.S))
        {
            player.velocity = new Vector2(player.velocity.x ,movespeed * -1f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            player.velocity = new Vector2(movespeed, player.velocity.y);
        }

        if (Input.GetKey(KeyCode.A))
        {
            player.velocity = new Vector2(movespeed * -1f, player.velocity.y);
        }


        */

        if(Input.GetKey(KeyCode.W))
        {
            player.AddForce(transform.up * movespeed, ForceMode2D.Impulse);
        }

        if(Input.GetKey(KeyCode.S))
        {
            player.AddForce(transform.up * (movespeed * -1f), ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.D))
        {
            player.AddForce(transform.right * movespeed, ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.A))
        {
            player.AddForce(transform.right * (movespeed * -1f), ForceMode2D.Impulse);
        }
    }
}
