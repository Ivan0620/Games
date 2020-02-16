using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxHp(int MaxHp)
    {
        slider.maxValue = MaxHp;
        slider.value = MaxHp;

    }

    public void SetHP(int Hp)
    {
        slider.value = Hp;
    }
}
