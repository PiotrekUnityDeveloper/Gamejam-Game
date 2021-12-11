using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlv : MonoBehaviour
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
            events evenent = GameObject.Find("EventSystem").GetComponent<events>();

            if(SceneManager.GetActiveScene().name == "SampleScene")
            {
                SceneManager.LoadScene("Level1");
            }
            else if (SceneManager.GetActiveScene().name == "Level1")
            {
                SceneManager.LoadScene("Level2");
            }
            else if (SceneManager.GetActiveScene().name == "Level2")
            {
                SceneManager.LoadScene("Level3");
            }
            else if (SceneManager.GetActiveScene().name == "Level3")
            {
                SceneManager.LoadScene("Level4");
            }
            else if (SceneManager.GetActiveScene().name == "Level4" && evenent.cangotonextlevel == true)
            {
                SceneManager.LoadScene("Level5");
                print("level5 loaded!");
            }

            if(evenent.cangotonextlevel == false)
            {
                evenent.triggercameratext("LOCKED - REQUIRES A KEY", Color.red, 2f);
            }
        }
    }
}
