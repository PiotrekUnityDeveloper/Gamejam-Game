using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerfollow : MonoBehaviour
{
    public bool canfollow = false;
    public Transform target;
    public float speed;

    //public Animator guardanim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //enemy follows player

        if(canfollow == true)
        {
            Vector3 moveDir = (target.position - transform.position).normalized;
            transform.position += moveDir * speed * Time.deltaTime;
            Quaternion rotation = Quaternion.LookRotation(target.transform.position - transform.position, transform.TransformDirection(Vector3.up));
            transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);

            //transform.LookAt(target);
        }
    }

    public void disableanimations()
    {
        //guardanim.SetBool("animate", false);S
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            events ev = GameObject.Find("EventSystem").GetComponent<events>();
            ev.gameover(1);
        }
    }




}
