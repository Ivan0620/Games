using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayGameIcon : MonoBehaviour
{
    public GameIcon Game;
    public TextMeshProUGUI nameText;
    public Image artwork;

    // Start is called before the first frame update
    void Start()
    {
        if (nameText != null)
            nameText.text = Game.gameName;
        else
            Debug.Log("Error!");

        if (Game.Locked == true)
        {
            nameText.text = Game.GamePrice.ToString()+" Gem";
            artwork.sprite = Game.Lockedlogo;
        }
        else
        {
            nameText.text = Game.gameName;
            artwork.sprite = Game.logo;
        }
    }
}
