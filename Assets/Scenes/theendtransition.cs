using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class theendtransition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(closetheend());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator closetheend()
    {
        yield return new WaitForSecondsRealtime(26f);
        SceneManager.LoadScene("MainMenu");
    }
}
