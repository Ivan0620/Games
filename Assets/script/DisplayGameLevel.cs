using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayGameLevel : MonoBehaviour
{
    public GameIcon GameLevel;
    public int level;
    public TextMeshProUGUI nameText;
    public Image artwork;

    // Start is called before the first frame update
    void Start()
    {
        if (nameText != null)
            nameText.text = GameLevel.gameName +" "+ level;
        else
            Debug.Log("Error!");

        artwork.sprite = GameLevel.logo;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
