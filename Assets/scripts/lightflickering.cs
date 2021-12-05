using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightflickering : MonoBehaviour
{
    public UnityEngine.Experimental.Rendering.Universal.Light2D SUN;

    public GameObject lightholder;

    //delays
    public float mintime;
    public float maxtime;

    public float intsity;

    // Start is called before the first frame update
    void Start()
    {
        //for changing light's intensity
        SUN = GetComponent<UnityEngine.Experimental.Rendering.Universal.Light2D>();
        intsity = SUN.intensity;

        StartCoroutine(lighton());
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public IEnumerator lighton()
    {
        yield return new WaitForSeconds(Random.Range(mintime, maxtime));

        //lightholder.SetActive(true);
        SUN.intensity = intsity;
        StartCoroutine(lightoff());

        print("on");
    }

    public IEnumerator lightoff()
    {
        yield return new WaitForSeconds(Random.Range(mintime, maxtime));

        //lightholder.SetActive(false);
        SUN.intensity = 0;
        StartCoroutine(lighton());

        print("off");
    }


}
