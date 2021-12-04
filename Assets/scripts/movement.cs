using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float movespeed;

    // Start is called before the first frame update
    void Start()
    {
        movespeed = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
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
    }
}
