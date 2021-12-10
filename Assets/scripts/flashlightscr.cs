using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class flashlightscr : MonoBehaviour
{
    public Vector2 mouseposition01;
    public Rigidbody2D flashlightrigid01;

    public events evobj;
    // Start is called before the first frame update
    void Start()
    {
        evobj = GameObject.Find("EventSystem").GetComponent<events>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        
        if (evobj.haveflashlight == true)
        {
            if (SceneManager.GetActiveScene().name == "Level4")
            {

                //mouseposition01 = Camera.main.ScreenToWorldPoint(Input.mousePosition);

               // Vector2 lookdir = (mouseposition01 - flashlightrigid01.position);
               // float msangle = Mathf.Atan2(lookdir.y, lookdir.x) * Mathf.Rad2Deg - 90f;
               // flashlightrigid01.rotation = msangle;

                //Quaternion rotation = Quaternion.LookRotation(mouseposition01.transform.position - (transform.position), transform.TransformDirection(Vector3.up));
                //transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);

            }
        }
    }
}
