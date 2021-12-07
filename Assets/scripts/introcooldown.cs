using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class introcooldown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(slideshow());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator slideshow()
    {
        print("coroutine started!");
        yield return new WaitForSecondsRealtime(5f);
        SceneManager.LoadScene("MainMenu");
    }
}
