using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotPlayer : MonoBehaviour
{
    public GameObject[] AllBtnBot;

    public static Sprite BotIcon;

    public Sprite Oimg;
    public Sprite Ximg;


    // Start is called before the first frame update
    void Start()
    {


        /*if(SceneMan.BotChoice == 2)
        {
            BotIcon = Ximg;
        }
        if (SceneMan.BotChoice == 1)
        {
            BotIcon = Oimg;
        }*/

        InvokeRepeating("AutoBotMode", 1.5f,1f);
    }

    // Update is called once per frame
    void Update()
    {
        

        //Debug.Log(AllBtnBot.Length);
        
        

        

    }
    
    public void AutoBotMode()
    {
        BotIcon = SceneMan.BotIcon;
        int AutoBot = Random.Range(0, AllBtnBot.Length);
        if (BTNFunction.BotChance == true)
        {
            if (AllBtnBot[AutoBot].GetComponent<Image>().sprite == null)
            {
                AllBtnBot[AutoBot].GetComponent<Image>().sprite = BotIcon;
                BTNFunction.BotChance = false;
                BTNFunction.PlayerChance = true;
                TempRayCastOpner();
               // Debug.Log("Autobot Number=" + AutoBot + "and you are inside");
                //Debug.Log(BotIcon.name);
            }
            else
            {
                AutoBot = Random.Range(0, AllBtnBot.Length);
            }

        }
    }
    public void TempRayCastOpner()
    {

        if (AllBtnBot[0].GetComponent<Image>().sprite == null)
        {
            AllBtnBot[0].GetComponent<Image>().raycastTarget = true;
        }

        if (AllBtnBot[1].GetComponent<Image>().sprite == null)
        {
            AllBtnBot[1].GetComponent<Image>().raycastTarget = true;
        }
        if (AllBtnBot[2].GetComponent<Image>().sprite == null)
        {
            AllBtnBot[2].GetComponent<Image>().raycastTarget = true;
        }
        if (AllBtnBot[3].GetComponent<Image>().sprite == null)
        {
            AllBtnBot[3].GetComponent<Image>().raycastTarget = true;
        }
        if (AllBtnBot[4].GetComponent<Image>().sprite == null)
        {
            AllBtnBot[4].GetComponent<Image>().raycastTarget = true;
        }
        if (AllBtnBot[5].GetComponent<Image>().sprite == null)
        {
            AllBtnBot[5].GetComponent<Image>().raycastTarget = true;
        }
        if (AllBtnBot[6].GetComponent<Image>().sprite == null)
        {
            AllBtnBot[6].GetComponent<Image>().raycastTarget = true;
        }
        if (AllBtnBot[7].GetComponent<Image>().sprite == null)
        {
            AllBtnBot[7].GetComponent<Image>().raycastTarget = true;
        }
        if (AllBtnBot[8].GetComponent<Image>().sprite == null)
        {
            AllBtnBot[8].GetComponent<Image>().raycastTarget = true;
        }
    }
    
}
