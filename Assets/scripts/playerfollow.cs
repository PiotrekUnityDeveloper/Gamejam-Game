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
        if(PlayerPrefs.GetInt("enemydeath", 0) == 1)
        {
            events ev = GameObject.Find("EventSystem").GetComponent<events>();
            ev.enemyhint();
        }
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
        events ev = GameObject.Find("EventSystem").GetComponent<events>();
        if (collision.collider.tag == "Player" && ev.haveguardsuit == false)
        {
            
            ev.gameover(1);
            PlayerPrefs.SetInt("enemydeath", 1);
            ev.enemyhint();
        }
    }




}
