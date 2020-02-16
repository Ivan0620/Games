using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelSelector : MonoBehaviour
{
    public Button[] LvButtons;
    public string valName;

    private void Start()
    {
        
        int LvReached = PlayerPrefs.GetInt(valName, 1);

        for (int i = 0; i < LvButtons.Length; i++)
        {
            if (i + 1 > LvReached) 
            LvButtons[i].interactable = false;
        }
    }

    public void Select(string LvName)
    {
        SceneManager.LoadScene(LvName);
    }
}
