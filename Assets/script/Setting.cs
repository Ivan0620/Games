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
            PlayerPrefs.SetInt("Game1LvReached", 1);
            PlayerPrefs.SetInt("Game2LvReached", 1);
            PlayerPrefs.SetInt("GemNum", 100);
            Game[0].Locked = true;
            Game[1].Locked = true;
            Game[2].Locked = true;
        }
        if (volume > -20)
        {
            PlayerPrefs.SetInt("Game1LvReached", 1);
            PlayerPrefs.SetInt("Game2LvReached", 1);
            PlayerPrefs.SetInt("GemNum", 150);
            Game[0].Locked = true;
            Game[1].Locked = true;
            Game[2].Locked = true;
        }
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


