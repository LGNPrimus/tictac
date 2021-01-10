using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinCondition : MonoBehaviour
{
    public GameObject WinBTn1;
    public GameObject WinBTn2;
    public GameObject WinBTn3;
    public GameObject WinBTn4;
    public GameObject WinBTn5;
    public GameObject WinBTn6;
    public GameObject WinBTn7;
    public GameObject WinBTn8;
    public GameObject WinBTn9;



    public static bool PlayerWin = false;
    public static bool BotWin = false;

    public string PLayerWinBtnName;
    public string BotWinBtnName;

    // Start is called before the first frame update
    void Start()
    {
        /*InvokeRepeating(" WinConitionCheckerPlayer", 5f,0.2f);
        InvokeRepeating(" WinBotChecker", 5f,0.2f);*/
    }

    // Update is called once per frame
    void Update()
    {
        PLayerWinBtnName = BTNFunction.playerIcon.name;
        BotWinBtnName = BotPlayer.BotIcon.name;
        Debug.Log(WinBTn5.GetComponent<Image>().sprite.name);
        Debug.Log(BotWinBtnName+"Bot Button Name");
        Debug.Log(PLayerWinBtnName+"Player Button Name");
        

       
    }
    private void FixedUpdate()
    {
        if (PlayerWin == false)
        {
            /*WinConitionCheckerPlayer();*/
        }
        if (BotWin == false)
        {


            /*WinBotChecker();*/
        }




        if (WinBTn1.GetComponent<Image>().sprite.name == PLayerWinBtnName && WinBTn2.GetComponent<Image>().sprite.name == PLayerWinBtnName && WinBTn3.GetComponent<Image>().sprite.name == PLayerWinBtnName)
        {
            PlayerWin = true;
            Debug.Log(PlayerWin + "123");
        }
        if (WinBTn1.GetComponent<Image>().sprite.name == PLayerWinBtnName && WinBTn4.GetComponent<Image>().sprite.name == PLayerWinBtnName && WinBTn7.GetComponent<Image>().sprite.name == PLayerWinBtnName)
        {
            PlayerWin = true;
            Debug.Log(PlayerWin + "147");
        }
        if (WinBTn1.GetComponent<Image>().sprite.name == PLayerWinBtnName && WinBTn5.GetComponent<Image>().sprite.name == PLayerWinBtnName && WinBTn9.GetComponent<Image>().sprite.name == PLayerWinBtnName)
        {
            PlayerWin = true;
            Debug.Log(PlayerWin + "159");
        }
        if (WinBTn2.GetComponent<Image>().sprite.name == PLayerWinBtnName && WinBTn5.GetComponent<Image>().sprite.name == PLayerWinBtnName && WinBTn8.GetComponent<Image>().sprite.name == PLayerWinBtnName)
        {
            PlayerWin = true;
            Debug.Log(PlayerWin + "258");
        }
        if (WinBTn3.GetComponent<Image>().sprite.name == PLayerWinBtnName && WinBTn6.GetComponent<Image>().sprite.name == PLayerWinBtnName && WinBTn9.GetComponent<Image>().sprite.name == PLayerWinBtnName)
        {
            PlayerWin = true;
            Debug.Log(PlayerWin + "369");
        }
        if (WinBTn3.GetComponent<Image>().sprite.name == PLayerWinBtnName && WinBTn5.GetComponent<Image>().sprite.name == PLayerWinBtnName && WinBTn7.GetComponent<Image>().sprite.name == PLayerWinBtnName)
        {
            PlayerWin = true;
            Debug.Log(PlayerWin + "357");
        }
        if (WinBTn4.GetComponent<Image>().sprite.name == PLayerWinBtnName && WinBTn5.GetComponent<Image>().sprite.name == PLayerWinBtnName && WinBTn6.GetComponent<Image>().sprite.name == PLayerWinBtnName)
        {
            PlayerWin = true;
            Debug.Log(PlayerWin + "456");
        }
        if (WinBTn7.GetComponent<Image>().sprite.name == PLayerWinBtnName && WinBTn8.GetComponent<Image>().sprite.name == PLayerWinBtnName && WinBTn9.GetComponent<Image>().sprite.name == PLayerWinBtnName)
        {
            PlayerWin = true;
            Debug.Log(PlayerWin + "789");
        }




        if (WinBTn1.GetComponent<Image>().sprite.name == BotWinBtnName && WinBTn2.GetComponent<Image>().sprite.name == BotWinBtnName && WinBTn3.GetComponent<Image>().sprite.name == BotWinBtnName)
        {
            BotWin = true;
            Debug.Log(BotWin + "123");
        }
        if (WinBTn1.GetComponent<Image>().sprite.name == BotWinBtnName && WinBTn4.GetComponent<Image>().sprite.name == BotWinBtnName && WinBTn7.GetComponent<Image>().sprite.name == BotWinBtnName)
        {
            BotWin = true;
            Debug.Log(BotWin + "147");
        }
        if (WinBTn1.GetComponent<Image>().sprite.name == BotWinBtnName && WinBTn5.GetComponent<Image>().sprite.name == BotWinBtnName && WinBTn9.GetComponent<Image>().sprite.name == BotWinBtnName)
        {
            BotWin = true;
            Debug.Log(BotWin + "159");
        }
        if (WinBTn2.GetComponent<Image>().sprite.name == BotWinBtnName && WinBTn5.GetComponent<Image>().sprite.name == BotWinBtnName && WinBTn8.GetComponent<Image>().sprite.name == BotWinBtnName)
        {
            BotWin = true;
            Debug.Log(BotWin + "258");
        }
         if (WinBTn3.GetComponent<Image>().sprite.name == BotWinBtnName && WinBTn6.GetComponent<Image>().sprite.name == BotWinBtnName && WinBTn9.GetComponent<Image>().sprite.name == BotWinBtnName)
        {
            BotWin = true;
            Debug.Log(BotWin + "369");
        }
        if (WinBTn3.GetComponent<Image>().sprite.name == BotWinBtnName && WinBTn5.GetComponent<Image>().sprite.name == BotWinBtnName && WinBTn7.GetComponent<Image>().sprite.name == BotWinBtnName)
        {
            BotWin = true;
            Debug.Log(BotWin + "357");
        }
        if (WinBTn4.GetComponent<Image>().sprite.name == BotWinBtnName && WinBTn5.GetComponent<Image>().sprite.name == BotWinBtnName && WinBTn6.GetComponent<Image>().sprite.name == BotWinBtnName)
        {
            BotWin = true;
            Debug.Log(BotWin + "456");
        }
        if (WinBTn7.GetComponent<Image>().sprite.name == BotWinBtnName && WinBTn8.GetComponent<Image>().sprite.name == BotWinBtnName && WinBTn9.GetComponent<Image>().sprite.name == BotWinBtnName)
        {
            BotWin = true;
            Debug.Log(BotWin + "789");
        }


    }


  /*  public void WinConitionCheckerPlayer()
    {
        */
        

        

    
 /*   public void WinBotChecker() {*/

        
        
    
}
