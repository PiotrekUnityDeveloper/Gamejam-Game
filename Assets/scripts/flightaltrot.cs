using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class flightaltrot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string dir;

    //public GameObject flashlight;

    public Rigidbody2D flashlightrigidbd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(dir == "up")
        {
            
            flashlightrigidbd.rotation = 0;
        }
        else if (dir == "down")
        {
            flashlightrigidbd.rotation = 180;
        }
        else if (dir == "right")
        {
            
            flashlightrigidbd.rotation = 270;
        }
        else if (dir == "left")
        {
            
            flashlightrigidbd.rotation = 90;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {

    }
}
