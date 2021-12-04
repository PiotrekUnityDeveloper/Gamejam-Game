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
        SpriteRenderer sr = new SpriteRenderer();
        sr = this.gameObject.GetComponent<SpriteRenderer>();

        for (int i = 0; i < 10; i++)
        {
            sr.color = new Color(1f, 1f, 1f, sr.color.a + 0.1f);
            yield return new WaitForSeconds(0.2f);
        }
    }

    public IEnumerator FadeOff()
    {
        SpriteRenderer sr = new SpriteRenderer();
        sr = this.gameObject.GetComponent<SpriteRenderer>();

        for (int i = 0; i < 10; i++)
        {
            sr.color = new Color(1f, 1f, 1f, sr.color.a - 0.1f);
            yield return new WaitForSeconds(0.1f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FadeOff();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        FadeOn();
    }
}
