using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class events : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        updateplayersfrictionandbounciness();
        //Physics.gravity = new Vector3(1f, -9.81f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Slider frictionslider;
    public Slider bounceslider;
    public Slider gravslider;
    public Toggle revgravitycheck;

    public GameObject PlayerObj;
    public PhysicsMaterial2D physmat;

    public float defaultgravity = 9.81f;

    public void updateplayersfrictionandbounciness()
    {
        //PlayerObj.GetComponent<PhysicsMaterial2D>().friction = frictionslider.value;
        PlayerObj.GetComponent<BoxCollider2D>().sharedMaterial.bounciness = bounceslider.value;
        PlayerObj.GetComponent<Rigidbody2D>().drag = frictionslider.value;
        PlayerObj.GetComponent<Rigidbody2D>().angularDrag = frictionslider.value;
        PlayerObj.GetComponent<Rigidbody2D>().gravityScale = gravslider.value;


        //PlayerObj.GetComponent<Collider2D>().enabled = false;
        //PlayerObj.GetComponent<Collider2D>().enabled = true;

        PlayerObj.GetComponent<BoxCollider2D>().enabled = false;
        PlayerObj.GetComponent<BoxCollider2D>().enabled = true;
        PlayerObj.GetComponent<BoxCollider2D>().sharedMaterial = null;
        PlayerObj.GetComponent<BoxCollider2D>().sharedMaterial = physmat;

        if(revgravitycheck.isOn == true)
        {
            //Physics.gravity = new Vector3(0f, defaultgravity, 0f);
        }
        else
        {
            //Physics.gravity = new Vector3(0f, (defaultgravity * -1f), 0f);
        }
    }
}
