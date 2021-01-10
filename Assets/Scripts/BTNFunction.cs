using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class BTNFunction : MonoBehaviour
{
    //All Individual 9 Buttons
    
    public  GameObject BTn1;
    public  GameObject BTn2;
    public  GameObject BTn3;
    public  GameObject BTn4;
    public  GameObject BTn5;
    public  GameObject BTn6;
    public  GameObject BTn7;
    public  GameObject BTn8;
    public  GameObject BTn9;


    public string BtnName1;
    public string BtnName2;
    public string BtnName3;
    public string BtnName4;
    public string BtnName5;
    public string BtnName6;
    public string BtnName7;
    public string BtnName8;
    public string BtnName9;

    //Taking reference of icons
    public Sprite Ximg;
    public Sprite Oimg;

   public static Sprite playerIcon;


    public static bool PlayerChance = true;
    public static bool BotChance = false;


    public static bool PlayerWin = false;
    public static bool BotWin = false;


    public string PLayerWinBtnName;
    public string BotWinBtnName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BTn1.GetComponent<Image>().sprite != null)
        {
            //Debug.Log("Nahi  Bhai Khali nahi h");
        }
        // Debug.Log(BotChance);



        PLayerWinBtnName = SceneMan.PlayerIcon.name;
        BotWinBtnName = SceneMan.BotIcon.name;
    }

    private void FixedUpdate()
    {
        if (BTn1.GetComponent<Image>().sprite.name == PLayerWinBtnName && BTn2.GetComponent<Image>().sprite.name == PLayerWinBtnName && BTn3.GetComponent<Image>().sprite.name == PLayerWinBtnName)
        {
            PlayerWin = true;
            Debug.Log(PlayerWin + "123");
        }
        if (BTn1.GetComponent<Image>().sprite.name == PLayerWinBtnName && BTn4.GetComponent<Image>().sprite.name == PLayerWinBtnName && BTn7.GetComponent<Image>().sprite.name == PLayerWinBtnName)
        {
            PlayerWin = true;
            Debug.Log(PlayerWin + "147");
        }
        if (BTn1.GetComponent<Image>().sprite.name == PLayerWinBtnName && BTn5.GetComponent<Image>().sprite.name == PLayerWinBtnName && BTn9.GetComponent<Image>().sprite.name == PLayerWinBtnName)
        {
            PlayerWin = true;
            Debug.Log(PlayerWin + "159");
        }
        if (BTn2.GetComponent<Image>().sprite.name == PLayerWinBtnName && BTn5.GetComponent<Image>().sprite.name == PLayerWinBtnName && BTn8.GetComponent<Image>().sprite.name == PLayerWinBtnName)
        {
            PlayerWin = true;
            Debug.Log(PlayerWin + "258");
        }
        if (BTn3.GetComponent<Image>().sprite.name == PLayerWinBtnName && BTn6.GetComponent<Image>().sprite.name == PLayerWinBtnName && BTn9.GetComponent<Image>().sprite.name == PLayerWinBtnName)
        {
            PlayerWin = true;
            Debug.Log(PlayerWin + "369");
        }
        if (BTn3.GetComponent<Image>().sprite.name == PLayerWinBtnName && BTn5.GetComponent<Image>().sprite.name == PLayerWinBtnName && BTn7.GetComponent<Image>().sprite.name == PLayerWinBtnName)
        {
            PlayerWin = true;
            Debug.Log(PlayerWin + "357");
        }
        if (BTn4.GetComponent<Image>().sprite.name == PLayerWinBtnName && BTn5.GetComponent<Image>().sprite.name == PLayerWinBtnName && BTn6.GetComponent<Image>().sprite.name == PLayerWinBtnName)
        {
            PlayerWin = true;
            Debug.Log(PlayerWin + "456");
        }
        if (BTn7.GetComponent<Image>().sprite.name == PLayerWinBtnName && BTn8.GetComponent<Image>().sprite.name == PLayerWinBtnName && BTn9.GetComponent<Image>().sprite.name == PLayerWinBtnName)
        {
            PlayerWin = true;
            Debug.Log(PlayerWin + "789");
        }




        if (BTn1.GetComponent<Image>().sprite.name == BotWinBtnName && BTn2.GetComponent<Image>().sprite.name == BotWinBtnName && BTn3.GetComponent<Image>().sprite.name == BotWinBtnName)
        {
            BotWin = true;
            Debug.Log(BotWin + "123");
        }
        if (BTn1.GetComponent<Image>().sprite.name == BotWinBtnName && BTn4.GetComponent<Image>().sprite.name == BotWinBtnName && BTn7.GetComponent<Image>().sprite.name == BotWinBtnName)
        {
            BotWin = true;
            Debug.Log(BotWin + "147");
        }
        if (BTn1.GetComponent<Image>().sprite.name == BotWinBtnName && BTn5.GetComponent<Image>().sprite.name == BotWinBtnName && BTn9.GetComponent<Image>().sprite.name == BotWinBtnName)
        {
            BotWin = true;
            Debug.Log(BotWin + "159");
        }
        if (BTn2.GetComponent<Image>().sprite.name == BotWinBtnName && BTn5.GetComponent<Image>().sprite.name == BotWinBtnName && BTn8.GetComponent<Image>().sprite.name == BotWinBtnName)
        {
            BotWin = true;
            Debug.Log(BotWin + "258");
        }
        if (BTn3.GetComponent<Image>().sprite.name == BotWinBtnName && BTn6.GetComponent<Image>().sprite.name == BotWinBtnName && BTn9.GetComponent<Image>().sprite.name == BotWinBtnName)
        {
            BotWin = true;
            Debug.Log(BotWin + "369");
        }
        if (BTn3.GetComponent<Image>().sprite.name == BotWinBtnName && BTn5.GetComponent<Image>().sprite.name == BotWinBtnName && BTn7.GetComponent<Image>().sprite.name == BotWinBtnName)
        {
            BotWin = true;
            Debug.Log(BotWin + "357");
        }
        if (BTn4.GetComponent<Image>().sprite.name == BotWinBtnName && BTn5.GetComponent<Image>().sprite.name == BotWinBtnName && BTn6.GetComponent<Image>().sprite.name == BotWinBtnName)
        {
            BotWin = true;
            Debug.Log(BotWin + "456");
        }
        if (BTn7.GetComponent<Image>().sprite.name == BotWinBtnName && BTn8.GetComponent<Image>().sprite.name == BotWinBtnName && BTn9.GetComponent<Image>().sprite.name == BotWinBtnName)
        {
            BotWin = true;
            Debug.Log(BotWin + "789");
        }
    }


    public void OnClickFun()
    {
        //Passing Button name to String For checking
        
            BtnName1 = BTn1.name;
            BtnName2 = BTn2.name;
            BtnName3 = BTn3.name;
            BtnName4 = BTn4.name;
            BtnName5 = BTn5.name;
            BtnName6 = BTn6.name;
            BtnName7 = BTn7.name;
            BtnName8 = BTn8.name;
            BtnName9 = BTn9.name;

        //PLayer Image Choosing From SceneMan Script
        
            playerIcon = SceneMan.PlayerIcon;
       
       


        if(PlayerChance == true)
        {

        }

        //Putting Image to a selected button

        if (EventSystem.current.currentSelectedGameObject.name == BtnName1)
        {
            BTn1.GetComponent<Image>().sprite = playerIcon;
            PlayerChance = false;
            BotChance = true;

            //Debug.Log(BTn1.GetComponent<Image>().sprite.name+"   Loo Jii naaaammmmm......");

            RayCastFun(BTn1);
            if (PlayerChance == false)
            {
                TempRayCastOffer();
            }
        }
       if(EventSystem.current.currentSelectedGameObject.name == BtnName2)
        {
            BTn2.GetComponent<Image>().sprite = playerIcon;
            PlayerChance = false;
            BotChance = true;
            RayCastFun(BTn2);
            if (PlayerChance == false)
            {
                TempRayCastOffer();
            }
        }
        if (EventSystem.current.currentSelectedGameObject.name == BtnName3)
        {
            BTn3.GetComponent<Image>().sprite = playerIcon;
            PlayerChance = false;
            BotChance = true;
            RayCastFun(BTn3);
            if (PlayerChance == false)
            {
                TempRayCastOffer();
            }
        }
        if (EventSystem.current.currentSelectedGameObject.name == BtnName4)
        {
            BTn4.GetComponent<Image>().sprite = playerIcon;
            PlayerChance = false;
            BotChance = true;
            RayCastFun(BTn4);
            if (PlayerChance == false)
            {
                TempRayCastOffer();
            }
        }
        if (EventSystem.current.currentSelectedGameObject.name == BtnName5)
        {
            BTn5.GetComponent<Image>().sprite = playerIcon;
            PlayerChance = false;
            BotChance = true;
            RayCastFun(BTn5);
            if (PlayerChance == false)
            {
                TempRayCastOffer();
            }
        }
        if (EventSystem.current.currentSelectedGameObject.name == BtnName6)
        {
            BTn6.GetComponent<Image>().sprite = playerIcon;
            PlayerChance = false;
            BotChance = true;
            RayCastFun(BTn6);
            if (PlayerChance == false)
            {
                TempRayCastOffer();
            }
        }
        if (EventSystem.current.currentSelectedGameObject.name == BtnName7)
        {
            BTn7.GetComponent<Image>().sprite = playerIcon;
            PlayerChance = false;
            BotChance = true;
            RayCastFun(BTn7);
            if (PlayerChance == false)
            {
                TempRayCastOffer();
            }
        }
        if (EventSystem.current.currentSelectedGameObject.name == BtnName8)
        {
            BTn8.GetComponent<Image>().sprite = playerIcon;
            PlayerChance = false;
            BotChance = true;
            RayCastFun(BTn8);
            if (PlayerChance == false)
            {
                TempRayCastOffer();
            }
        }
        if (EventSystem.current.currentSelectedGameObject.name == BtnName9)
        {
            BTn9.GetComponent<Image>().sprite = playerIcon;
            PlayerChance = false;
            BotChance = true;
            RayCastFun(BTn9);
            if (PlayerChance == false)
            {
                TempRayCastOffer();
            }
        }
    
        
    }
    public void RayCastFun(GameObject BtnName)
    {
        BtnName.GetComponent<Image>().raycastTarget = false;
       
    }
    public void TempRayCastOffer()
    {

        if (BTn1.GetComponent<Image>().sprite == null)
        {
            BTn1.GetComponent<Image>().raycastTarget = false;
        }
       
        if (BTn2.GetComponent<Image>().sprite == null)
        {
            BTn2.GetComponent<Image>().raycastTarget = false;
            //Debug.Log(BTn2.GetComponent<Image>().raycastTarget);
           
        }
        if (BTn3.GetComponent<Image>().sprite == null)
        {
            BTn3.GetComponent<Image>().raycastTarget = false;
        }
        if (BTn4.GetComponent<Image>().sprite == null)
        {
            BTn4.GetComponent<Image>().raycastTarget = false;
        }
        if (BTn5.GetComponent<Image>().sprite == null)
        {
            BTn5.GetComponent<Image>().raycastTarget = false;
        }
        if (BTn6.GetComponent<Image>().sprite == null)
        {
            BTn6.GetComponent<Image>().raycastTarget = false;
        }
        if (BTn7.GetComponent<Image>().sprite == null)
        {
            BTn7.GetComponent<Image>().raycastTarget = false;
        }
        if (BTn8.GetComponent<Image>().sprite == null)
        {
            BTn8.GetComponent<Image>().raycastTarget = false;
        }
        if (BTn9.GetComponent<Image>().sprite == null)
        {
            BTn9.GetComponent<Image>().raycastTarget = false;
        }
    }
}
