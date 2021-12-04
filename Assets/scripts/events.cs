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
    

    public Slider frictionslider;
    public Slider bounceslider;
    public Slider gravslider;
    public Toggle revgravitycheck;

    public GameObject PlayerObj;
    public PhysicsMaterial2D physmat;

    public float defaultgravity = 9.81f;

    public Slider movespeedmodifier;

    public GameObject bouncewarning;
    public GameObject frictionwarning;

    void Update()
    {
        if(frictionslider.value < 0.8f)
        {
            if(bounceslider.value > 0.5f)
            {
                bouncewarning.SetActive(true);
                //frictionslider.value = 2;
                bounceslider.value = 0.6f;
                updateplayersfrictionandbounciness();
            }
            else
            {
                bouncewarning.SetActive(false);
            }
        }
        else
        {
            bouncewarning.SetActive(false);
        }

        if (bounceslider.value > 0.5f)
        {
            if (frictionslider.value < 0.5f)
            {
                frictionwarning.SetActive(true);
                bounceslider.value = 0f;
                updateplayersfrictionandbounciness();
            }
            else
            {
                frictionwarning.SetActive(false);
            }
        }
        else
        {
            frictionwarning.SetActive(false);
            //bouncewarning.SetActive(false); 
        }
    }

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

        PlayerObj.GetComponent<movement>().movespeed = movespeedmodifier.value;
    }

    public void resetgrav()
    {
        gravslider.value = 0;
        updateplayersfrictionandbounciness();
    }

    public void resetmoves()
    {
        PlayerObj.GetComponent<movement>().movespeed = 0.2f;
        movespeedmodifier.value = 0.2f;
        updateplayersfrictionandbounciness();
    }
}
