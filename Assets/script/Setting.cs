using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class Setting : MonoBehaviour
{
    public AudioMixer audioMixer;
    public GameIcon[] Game;

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
        if (volume < -50) 
        {
            ReSetGame(1, 100);
        }
        if (volume > -20)
        {
            ReSetGame(1, 150);
        }
    }
    void ReSetGame(int GameLv,int Gem)
    {
        PlayerPrefs.SetInt("Game1LvReached", GameLv);
        PlayerPrefs.SetInt("Game2LvReached", GameLv);
        PlayerPrefs.SetInt("Game3LvReached", GameLv);
        PlayerPrefs.SetInt("GemNum", Gem);
        Game[0].Locked = true;
        Game[1].Locked = true;
        Game[2].Locked = true;
        Game[3].Locked = true;
    }

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
        if(isFullScreen)
            PlayerPrefs.SetInt("fullScreened", 1);
        else
            PlayerPrefs.SetInt("fullScreened", 0);
    }

}


