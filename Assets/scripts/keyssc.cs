using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyssc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            events eventt = GameObject.Find("EventSystem").GetComponent<events>();
            eventt.cangotonextlevel = true;
            Destroy(this.gameObject);
        }
    }
}
