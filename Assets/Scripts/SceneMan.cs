using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SceneMan : MonoBehaviour
{
    public GameObject ChoosingPNL;
    public GameObject GamePNL;
    public GameObject WinLossePnl;
    public GameObject PlayerWinText;
    public GameObject BotWinText;

    public GameObject XBTn;
    public GameObject OBTn;

    public Sprite Ximg;
    public Sprite Oimg;


    public static int PlayerChoice;
    public static int BotChoice;


    public static Sprite PlayerIcon;
    public static Sprite BotIcon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(WinCondition.PlayerWin);
        Debug.Log(WinCondition.BotWin );

        if(BTNFunction.PlayerWin == true)
        {
            
            WinLossePnl.SetActive(true);
            PlayerWinText.SetActive(true);
            Time.timeScale = 0f;
            WinCondition.PlayerWin = false;
        }
        if (BTNFunction.BotWin == true)
        {

            WinLossePnl.SetActive(true);
            BotWinText.SetActive(true);
            Time.timeScale = 0f;
            WinCondition.BotWin = false;
        }
    }

    public void ResetBTN()
    {
        WinLossePnl.SetActive(false);
        BotWinText .SetActive(false);          
        PlayerWinText.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
    public void AfterChoose()
    {
        string O = OBTn.name;
        string X = XBTn.name;

        if (EventSystem.current.currentSelectedGameObject.name == O)
        {
            /*PlayerChoice = 1;
            BotChoice = 2;*/
            PlayerIcon = Oimg;
            BotIcon = Ximg;
            ChoosingPNL.SetActive(false);
            GamePNL.SetActive(true);

        }
        else if(EventSystem.current.currentSelectedGameObject.name == X)
        {
            /*PlayerChoice = 2;
            BotChoice = 1;*/
            PlayerIcon = Ximg;
            BotIcon = Oimg;

            ChoosingPNL.SetActive(false);
            GamePNL.SetActive(true);
        }
    }
}
