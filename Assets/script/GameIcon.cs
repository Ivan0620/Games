using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Game",menuName ="Game")]
public class GameIcon : ScriptableObject
{
    public string gameName;
    public Sprite logo;
    public Sprite Lockedlogo;
    public bool Locked;
    public int GamePrice;
}
