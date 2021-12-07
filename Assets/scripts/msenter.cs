using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class msenter : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Text buttontxt;
    public int textid;

    //custom values
    public AudioSource on1;
    public AudioSource on2;
    public AudioSource on3;
    public AudioSource on4;

    public AudioSource off1;

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
        if(textid == 1)
        {
            buttontxt.text = "NOT SO EZ M8";
        }
        else if (textid == 2)
        {
            buttontxt.text = ">PLAY";
            int e = Random.Range(0, 5);
            switch(e)
            {
                case 1:
                    on1.Play();
                    break;
                case 2:
                    on2.Play();
                    break;
                case 3:
                    on3.Play();
                    break;
                case 4:
                    on4.Play();
                    break;
                case 5:
                    on1.Play();
                    break;
            }
        }
        else if (textid == 3)
        {
            buttontxt.text = ">OPTIONS";
            int e = Random.Range(0, 5);
            switch (e)
            {
                case 1:
                    on1.Play();
                    break;
                case 2:
                    on2.Play();
                    break;
                case 3:
                    on3.Play();
                    break;
                case 4:
                    on4.Play();
                    break;
                case 5:
                    on1.Play();
                    break;
            }
        }
        else if (textid == 4)
        {
            buttontxt.text = ">CREDITS";
            int e = Random.Range(0, 5);
            switch (e)
            {
                case 1:
                    on1.Play();
                    break;
                case 2:
                    on2.Play();
                    break;
                case 3:
                    on3.Play();
                    break;
                case 4:
                    on4.Play();
                    break;
                case 5:
                    on1.Play();
                    break;
            }
        }
        else if (textid == 5)
        {
            buttontxt.text = ">HOW TO PLAY";
            int e = Random.Range(0, 5);
            switch (e)
            {
                case 1:
                    on1.Play();
                    break;
                case 2:
                    on2.Play();
                    break;
                case 3:
                    on3.Play();
                    break;
                case 4:
                    on4.Play();
                    break;
                case 5:
                    on1.Play();
                    break;
            }
        }
        else if (textid == 6)
        {
            buttontxt.text = ">EXIT";
            int e = Random.Range(0, 5);
            switch (e)
            {
                case 1:
                    on1.Play();
                    break;
                case 2:
                    on2.Play();
                    break;
                case 3:
                    on3.Play();
                    break;
                case 4:
                    on4.Play();
                    break;
                case 5:
                    on1.Play();
                    break;
            }
        }
        else if (textid == 7)
        {
            buttontxt.text = ">LOAD GAME";
            int e = Random.Range(0, 5);
            switch (e)
            {
                case 1:
                    on1.Play();
                    break;
                case 2:
                    on2.Play();
                    break;
                case 3:
                    on3.Play();
                    break;
                case 4:
                    on4.Play();
                    break;
                case 5:
                    on1.Play();
                    break;
            }
        }
        else if (textid == 8)
        {
            buttontxt.text = ">NEW GAME";
            int e = Random.Range(0, 5);
            switch (e)
            {
                case 1:
                    on1.Play();
                    break;
                case 2:
                    on2.Play();
                    break;
                case 3:
                    on3.Play();
                    break;
                case 4:
                    on4.Play();
                    break;
                case 5:
                    on1.Play();
                    break;
            }
        }
        else if (textid == 9)
        {
            buttontxt.text = ">JUST EXIT";
            int e = Random.Range(0, 5);
            switch (e)
            {
                case 1:
                    on1.Play();
                    break;
                case 2:
                    on2.Play();
                    break;
                case 3:
                    on3.Play();
                    break;
                case 4:
                    on4.Play();
                    break;
                case 5:
                    on1.Play();
                    break;
            }
        }
        else if (textid == 10)
        {
            buttontxt.text = ">RAGE QUIT";
            int e = Random.Range(0, 5);
            switch (e)
            {
                case 1:
                    on1.Play();
                    break;
                case 2:
                    on2.Play();
                    break;
                case 3:
                    on3.Play();
                    break;
                case 4:
                    on4.Play();
                    break;
                case 5:
                    on1.Play();
                    break;
            }
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (textid == 1)
        {
            buttontxt.text = "GAME FULLBRIGHT";
        }
        else if(textid == 2)
        {
            buttontxt.text = "> PLAY";
            off1.Play();
        }
        else if (textid == 3)
        {
            buttontxt.text = "> OPTIONS";
            off1.Play();
        }
        else if (textid == 4)
        {
            buttontxt.text = "> CREDITS";
            off1.Play();
        }
        else if (textid == 5)
        {
            buttontxt.text = "> HOW TO PLAY";
            off1.Play();
        }
        else if (textid == 6)
        {
            buttontxt.text = "> EXIT";
            off1.Play();
        }
        else if(textid == 7)
        {
            buttontxt.text = "> LOAD GAME";
            off1.Play();
        }
        else if(textid == 8)
        {
            buttontxt.text = "> NEW GAME";
            off1.Play();
        }
        else if (textid == 9)
        {
            buttontxt.text = "> JUST EXIT";
            off1.Play();
        }
        else if (textid == 10)
        {
            buttontxt.text = "> RAGE QUIT";
            off1.Play();
        }

    }
}
