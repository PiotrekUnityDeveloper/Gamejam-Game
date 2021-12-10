using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class flightaltrot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string dir;
    public GameObject requestedrotationobject;

    //public GameObject flashlight;

    public Rigidbody2D flashlightrigidbd;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = GameObject.Find("ludzik").transform.position;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(dir == "up")
        {
            
            //flashlightrigidbd.rotation = 0;

            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.z = 0;
            requestedrotationobject.transform.rotation = Quaternion.Euler(rotationVector);

            print("flashlight rotated up");
        }
        else if (dir == "down")
        {
            //flashlightrigidbd.rotation = 180;

            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.z = 180;
            requestedrotationobject.transform.rotation = Quaternion.Euler(rotationVector);

            print("flashlight rotated down");
        }
        else if (dir == "right")
        {
            
            ///flashlightrigidbd.rotation = 270;

            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.z = 270;
            requestedrotationobject.transform.rotation = Quaternion.Euler(rotationVector);

            print("flashlight rotated right");
        }
        else if (dir == "left")
        {
            
            //flashlightrigidbd.rotation = 90;

            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.z = 90;
            requestedrotationobject.transform.rotation = Quaternion.Euler(rotationVector);

            print("flashlight rotated left");
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {

    }
}
