using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountCollction : MonoBehaviour
{
    string[] Cherry = { "G2RedCherry", "G2BlackCherry", "G2BlueCherry", "G2GreenCherry" };
    int NumMissionDone = 0;
    int[] arrNumCherry;
    bool nextLv = true;

    public TextMeshProUGUI[] ArrOfCherry;
    public int[] arrNumCherryNeed;
    public GameObject winGame;
    public GameObject loseGame;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Cherry.Length; i++)
        {
            ArrOfCherry[i].text = arrNumCherryNeed[i].ToString();
            PlayerPrefs.SetInt(Cherry[i], arrNumCherryNeed[i]);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            for (int i = 0; i < Cherry.Length; i++)
            {
                if (PlayerPrefs.GetInt(Cherry[i], 0) != 0)
                {
                    Time.timeScale = 0f;
                    loseGame.SetActive(true);
                    nextLv = false;
                }
                PlayerPrefs.SetInt(Cherry[i], 0);
            }
            if (nextLv)
            {
                Time.timeScale = 0f;
                winGame.SetActive(true);
                Debug.Log(NumMissionDone);
            }
        }
    }

    public void CheckMission()
    {

    }
}
