using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tranparency : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator FadeOn()
    {
        /*
        SpriteRenderer sr = new SpriteRenderer();
        sr = this.gameObject.GetComponent<SpriteRenderer>();

        for (int i = 0; i < 10; i++)
        {
            sr.color = new Color(1f, 1f, 1f, sr.color.a + 0.1f);
            yield return new WaitForSeconds(0.1f);
        }
        */

        /*
        SpriteRenderer sr = new SpriteRenderer();
        sr = this.gameObject.GetComponent<SpriteRenderer>();

        sr.color = new Color(1f, 1f, 1f, 0.1f);

        sr.color = new Color(1f, 1f, 1f, sr.color.a + 25.5f);
        yield return new WaitForSeconds(0.1f);
        sr.color = new Color(1f, 1f, 1f, sr.color.a + 25.5f);
        yield return new WaitForSeconds(0.1f);
        sr.color = new Color(1f, 1f, 1f, sr.color.a + 25.5f);
        yield return new WaitForSeconds(0.1f);
        sr.color = new Color(1f, 1f, 1f, sr.color.a + 25.5f);
        //yield return new WaitForSeconds(0.1f);
        //sr.color = new Color(1f, 1f, 1f, sr.color.a + 25.5f);
        yield return new WaitForSeconds(0.1f);
        sr.color = new Color(1f, 1f, 1f, sr.color.a + 25.5f);
        yield return new WaitForSeconds(0.1f);
        sr.color = new Color(1f, 1f, 1f, sr.color.a + 25.5f);
        yield return new WaitForSeconds(0.1f);
        sr.color = new Color(1f, 1f, 1f, sr.color.a + 25.5f);
        yield return new WaitForSeconds(0.1f);
        sr.color = new Color(1f, 1f, 1f, sr.color.a + 25.5f);
        yield return new WaitForSeconds(0.1f);
        //sr.color = new Color(1f, 1f, 1f, sr.color.a + 25.5f);
        //yield return new WaitForSeconds(0.1f);
        sr.color = new Color(1f, 1f, 1f, 0.9f);

        //bad code practice, not approved

        */

        GetComponent<Renderer>().material.color = new Color(255, 255, 255, 0);

        yield return new WaitForSeconds(0.190f);
        GetComponent<Renderer>().material.color = new Color(255, 255, 255, (GetComponent<Renderer>().material.color.a + 20));
        yield return new WaitForSeconds(0.190f);
        GetComponent<Renderer>().material.color = new Color(255, 255, 255, (GetComponent<Renderer>().material.color.a + 20));
        yield return new WaitForSeconds(0.190f);
        GetComponent<Renderer>().material.color = new Color(255, 255, 255, (GetComponent<Renderer>().material.color.a + 20));
        yield return new WaitForSeconds(0.190f);
        GetComponent<Renderer>().material.color = new Color(255, 255, 255, (GetComponent<Renderer>().material.color.a + 20));
        yield return new WaitForSeconds(0.190f);
        GetComponent<Renderer>().material.color = new Color(255, 255, 255, (GetComponent<Renderer>().material.color.a + 20));
        yield return new WaitForSeconds(0.190f);
        GetComponent<Renderer>().material.color = new Color(255, 255, 255, (GetComponent<Renderer>().material.color.a + 20));
        yield return new WaitForSeconds(0.190f);
        GetComponent<Renderer>().material.color = new Color(255, 255, 255, (GetComponent<Renderer>().material.color.a + 20));
        yield return new WaitForSeconds(0.190f);
        GetComponent<Renderer>().material.color = new Color(255, 255, 255, (GetComponent<Renderer>().material.color.a + 20));
        yield return new WaitForSeconds(0.190f);
        GetComponent<Renderer>().material.color = new Color(255, 255, 255, (GetComponent<Renderer>().material.color.a + 20));
        yield return new WaitForSeconds(0.190f);
        GetComponent<Renderer>().material.color = new Color(255, 255, 255, (GetComponent<Renderer>().material.color.a + 20));

        GetComponent<Renderer>().material.color = new Color(255, 255, 255, 200);

        print("done");

        print("done");
    }

    public IEnumerator FadeOff()
    {
        /*
        SpriteRenderer sr = new SpriteRenderer();
        sr = this.gameObject.GetComponent<SpriteRenderer>();

        for (int i = 0; i < 10; i++)
        {
            sr.color = new Color(1f, 1f, 1f, sr.color.a - 0.1f);
            yield return new WaitForSeconds(0.2f);
        }
        */

        /*

        SpriteRenderer sr = new SpriteRenderer();
        sr = this.gameObject.GetComponent<SpriteRenderer>();

        sr.color = new Color(1f, 1f, 1f, 0.9f);

        sr.color = new Color(1f, 1f, 1f, sr.color.a - 25.5f);
        yield return new WaitForSeconds(0.190f);
        sr.color = new Color(1f, 1f, 1f, sr.color.a - 25.5f);
        yield return new WaitForSeconds(0.190f);
        sr.color = new Color(1f, 1f, 1f, sr.color.a - 25.5f);
        yield return new WaitForSeconds(0.190f);
        sr.color = new Color(1f, 1f, 1f, sr.color.a - 25.5f);
        yield return new WaitForSeconds(0.190f);
        sr.color = new Color(1f, 1f, 1f, sr.color.a - 25.5f);
        yield return new WaitForSeconds(0.190f);
        sr.color = new Color(1f, 1f, 1f, sr.color.a - 25.5f);
        yield return new WaitForSeconds(0.190f);
        sr.color = new Color(1f, 1f, 1f, sr.color.a - 25.5f);
        yield return new WaitForSeconds(0.190f);
        sr.color = new Color(1f, 1f, 1f, sr.color.a - 25.5f);
        yield return new WaitForSeconds(0.190f);

        sr.color = new Color(1f, 1f, 1f, 0.1f);

        */

        GetComponent<Renderer>().material.color = new Color(255, 255, 255, 200);

        yield return new WaitForSeconds(0.190f);
        GetComponent<Renderer>().material.color = new Color(255, 255, 255, (GetComponent<Renderer>().material.color.a - 20));
        yield return new WaitForSeconds(0.190f);
        GetComponent<Renderer>().material.color = new Color(255, 255, 255, (GetComponent<Renderer>().material.color.a - 20));
        yield return new WaitForSeconds(0.190f);
        GetComponent<Renderer>().material.color = new Color(255, 255, 255, (GetComponent<Renderer>().material.color.a - 20));
        yield return new WaitForSeconds(0.190f);
        GetComponent<Renderer>().material.color = new Color(255, 255, 255, (GetComponent<Renderer>().material.color.a - 20));
        yield return new WaitForSeconds(0.190f);
        GetComponent<Renderer>().material.color = new Color(255, 255, 255, (GetComponent<Renderer>().material.color.a - 20));
        yield return new WaitForSeconds(0.190f);
        GetComponent<Renderer>().material.color = new Color(255, 255, 255, (GetComponent<Renderer>().material.color.a - 20));
        yield return new WaitForSeconds(0.190f);
        GetComponent<Renderer>().material.color = new Color(255, 255, 255, (GetComponent<Renderer>().material.color.a - 20));
        yield return new WaitForSeconds(0.190f);
        GetComponent<Renderer>().material.color = new Color(255, 255, 255, (GetComponent<Renderer>().material.color.a - 20));
        yield return new WaitForSeconds(0.190f);
        GetComponent<Renderer>().material.color = new Color(255, 255, 255, (GetComponent<Renderer>().material.color.a - 20));
        yield return new WaitForSeconds(0.190f);
        GetComponent<Renderer>().material.color = new Color(255, 255, 255, (GetComponent<Renderer>().material.color.a - 20));

        GetComponent<Renderer>().material.color = new Color(255, 255, 255, 0);

        print("done");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FadeOff();
        print("it works!");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        FadeOn();
        print("it works too!");
    }
}
