using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G3GM : MonoBehaviour
{
    public GameObject WinObj;
    public int NumToKill = 0;
    void Update()
    {
        if (PlayerPrefs.GetInt("G3Kill", 0) >= NumToKill)
            Invoke("WinGame", 1);
    }

    void WinGame()
    {
        Time.timeScale = 0f;
        WinObj.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        PlayerPrefs.SetInt("G3Kill", 0);
    }
}
