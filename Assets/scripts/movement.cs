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

        if(this.isActiveAndEnabled == true)
        {
            if (Input.GetKey(KeyCode.W))
            {
                player.AddForce(transform.up * movespeed, ForceMode2D.Impulse);
            }

            if (Input.GetKey(KeyCode.S))
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

            //arrow keys

            if (Input.GetKey(KeyCode.UpArrow))
            {
                player.AddForce(transform.up * movespeed, ForceMode2D.Impulse);
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                player.AddForce(transform.up * (movespeed * -1f), ForceMode2D.Impulse);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                player.AddForce(transform.right * movespeed, ForceMode2D.Impulse);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                player.AddForce(transform.right * (movespeed * -1f), ForceMode2D.Impulse);
            }
        }



        
    }
}
