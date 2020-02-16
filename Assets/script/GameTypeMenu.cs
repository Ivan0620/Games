using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameTypeMenu : MonoBehaviour
{
    static int GameNum;
    static int Gem;
    static float time;
    public int timeToCount = 30;
    public Image[] artwork;
    public TextMeshProUGUI[] nameText;
    public TextMeshProUGUI ChestTime;
    public GameIcon[] Game;
    public Button btn;

    [SerializeField]
    Text NumGem;

    [SerializeField]
    string hoverOverSound = "ButtonHover";

    [SerializeField]
    string pressButtonSound = "ButtonPress";

    AudioManager audioManager;

    private void Start()
    {
        time = timeToCount;
        btn.interactable = false;
        GameNum = PlayerPrefs.GetInt("GameNum", 1);
        //PlayerPrefs.SetInt("GemNum", 150);
        Gem = PlayerPrefs.GetInt("GemNum", 100);
        NumGem.text = Gem.ToString();
        if (artwork == null)
        {
            Debug.LogError("No artwork found!");
        }
        audioManager = AudioManager.instance;
        if (audioManager == null)
        {
            Debug.LogError("No audiomanager found!");
        }
    }

    public void PlayGame(int GameIndex)
    {
        if (Game[GameIndex - 2].Locked == false)
        {
            SceneManager.LoadScene(GameIndex);
        }
        else
            BuyGame(GameIndex);
    }

    void BuyGame(int GameIndex)
    {
        if (Gem >= Game[GameIndex - 2].GamePrice)
        {
            Gem -= Game[GameIndex - 2].GamePrice;
            NumGem.text = Gem.ToString();
            GameNum = GameIndex;
            Game[GameIndex-2].Locked = false;
            artwork[GameIndex - 2].sprite = Game[GameIndex - 2].logo;
            nameText[GameIndex - 2].text = Game[GameIndex - 2].gameName;
            PlayerPrefs.SetInt("GameNum", GameNum);
            PlayerPrefs.SetInt("GemNum", Gem);
        }
        else
            Debug.Log("Check Your Gem!!");

    }

    public void onMouseOver()
    {
        audioManager.PlaySound(hoverOverSound);
    }

    public void BackToMain(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void OpenChest()
    {
        if (time <= 0)
        {
            Gem = Gem + 1;
            PlayerPrefs.SetInt("GemNum", Gem);
            NumGem.text = Gem.ToString();
            time = timeToCount;
            btn.interactable = false;
        }
    }

    private void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
            ChestTime.text = time.ToString("F0") + "s";
        }
        else
            btn.interactable = true;
    }
}
