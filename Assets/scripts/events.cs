using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class events : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Slider frictionslider;
    public GameObject PlayerObj;

    public void updateplayersfrictionandbounciness()
    {
        //PlayerObj.GetComponent<PhysicsMaterial2D>().friction = frictionslider.value;
        //PlayerObj.GetComponent<BoxCollider2D>().sharedMaterial.friction = frictionslider.value;
        PlayerObj.GetComponent<Rigidbody2D>().drag = frictionslider.value;
        PlayerObj.GetComponent<Rigidbody2D>().angularDrag = frictionslider.value;
    }
}
