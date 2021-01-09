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

    public Sprite PLayerWinBtnName;
    public Sprite BotWinBtnName;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(" WinConitionChecker", 5f,0.2f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    public void WinConitionChecker()
    {
        PLayerWinBtnName = BTNFunction.playerIcon;
        BotWinBtnName = BotPlayer.BotIcon;
        if (WinBTn1.GetComponent<Image>().sprite.name == PLayerWinBtnName.name && WinBTn2.GetComponent<Image>().sprite.name == SceneMan.PlayerIcon.name && WinBTn3.GetComponent<Image>().sprite.name == SceneMan.PlayerIcon.name)
        {
            PlayerWin = true;
            Debug.Log(PlayerWin);
        }
        else if (WinBTn1.GetComponent<Image>().sprite.name == PLayerWinBtnName.name && WinBTn4.GetComponent<Image>().sprite.name == SceneMan.PlayerIcon.name && WinBTn8.GetComponent<Image>().sprite.name == SceneMan.PlayerIcon.name)
        {
            PlayerWin = true;
        }
        else if (WinBTn1.GetComponent<Image>().sprite.name == PLayerWinBtnName.name && WinBTn5.GetComponent<Image>().sprite.name == SceneMan.PlayerIcon.name && WinBTn9.GetComponent<Image>().sprite.name == SceneMan.PlayerIcon.name)
        {
            PlayerWin = true;
        }
        else if (WinBTn2.GetComponent<Image>().sprite.name == PLayerWinBtnName.name && WinBTn5.GetComponent<Image>().sprite.name == SceneMan.PlayerIcon.name && WinBTn8.GetComponent<Image>().sprite.name == SceneMan.PlayerIcon.name)
        {
            PlayerWin = true;
        }
        else if (WinBTn3.GetComponent<Image>().sprite.name == PLayerWinBtnName.name && WinBTn6.GetComponent<Image>().sprite.name == SceneMan.PlayerIcon.name && WinBTn9.GetComponent<Image>().sprite.name == SceneMan.PlayerIcon.name)
        {
            PlayerWin = true;
        }
        else if (WinBTn3.GetComponent<Image>().sprite.name == PLayerWinBtnName.name && WinBTn5.GetComponent<Image>().sprite.name == SceneMan.PlayerIcon.name && WinBTn7.GetComponent<Image>().sprite.name == SceneMan.PlayerIcon.name)
        {
            PlayerWin = true;
        }
        else if (WinBTn4.GetComponent<Image>().sprite.name == PLayerWinBtnName.name && WinBTn5.GetComponent<Image>().sprite.name == SceneMan.PlayerIcon.name && WinBTn6.GetComponent<Image>().sprite.name == SceneMan.PlayerIcon.name)
        {
            PlayerWin = true;
        }
        else if (WinBTn7.GetComponent<Image>().sprite.name == PLayerWinBtnName.name && WinBTn8.GetComponent<Image>().sprite.name == SceneMan.PlayerIcon.name && WinBTn9.GetComponent<Image>().sprite.name == SceneMan.PlayerIcon.name)
        {
            PlayerWin = true;
        }




        else if (WinBTn1.GetComponent<Image>().sprite.name == SceneMan.BotIcon.name && WinBTn2.GetComponent<Image>().sprite.name == SceneMan.BotIcon.name && WinBTn3.GetComponent<Image>().sprite.name == SceneMan.BotIcon.name)
        {
            BotWin = true;
        }
        else if (WinBTn1.GetComponent<Image>().sprite.name == SceneMan.BotIcon.name && WinBTn4.GetComponent<Image>().sprite.name == SceneMan.BotIcon.name && WinBTn8.GetComponent<Image>().sprite.name == SceneMan.BotIcon.name)
        {
            BotWin = true;
        }
        else if (WinBTn1.GetComponent<Image>().sprite.name == SceneMan.BotIcon.name && WinBTn5.GetComponent<Image>().sprite.name == SceneMan.BotIcon.name && WinBTn9.GetComponent<Image>().sprite.name == SceneMan.BotIcon.name)
        {
            BotWin = true;
        }
        else if (WinBTn2.GetComponent<Image>().sprite.name == SceneMan.BotIcon.name && WinBTn5.GetComponent<Image>().sprite.name == SceneMan.BotIcon.name && WinBTn8.GetComponent<Image>().sprite.name == SceneMan.BotIcon.name)
        {
            BotWin = true;
        }
        else if (WinBTn3.GetComponent<Image>().sprite.name == SceneMan.BotIcon.name && WinBTn6.GetComponent<Image>().sprite.name == SceneMan.BotIcon.name && WinBTn9.GetComponent<Image>().sprite.name == SceneMan.BotIcon.name)
        {
            BotWin = true;
        }
        else if (WinBTn3.GetComponent<Image>().sprite.name == SceneMan.BotIcon.name && WinBTn5.GetComponent<Image>().sprite.name == SceneMan.BotIcon.name && WinBTn7.GetComponent<Image>().sprite.name == SceneMan.BotIcon.name)
        {
            BotWin = true;
        }
        else if (WinBTn4.GetComponent<Image>().sprite.name == SceneMan.BotIcon.name && WinBTn5.GetComponent<Image>().sprite.name == SceneMan.BotIcon.name && WinBTn6.GetComponent<Image>().sprite.name == SceneMan.BotIcon.name)
        {
            BotWin = true;
        }
        else if (WinBTn7.GetComponent<Image>().sprite.name == SceneMan.BotIcon.name && WinBTn8.GetComponent<Image>().sprite.name == SceneMan.BotIcon.name && WinBTn9.GetComponent<Image>().sprite.name == SceneMan.BotIcon.name)
        {
            BotWin = true;
        }
    }
}
