using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    public int health = 100;
    public int  Maxhealth = 100;
    public HpBar hpBar;
    public GameObject explotion;

    private void Start()
    {

        health = Maxhealth;
        hpBar.SetMaxHp(Maxhealth);
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        hpBar.SetHP(health);
        Debug.Log(health);
        if (health <= 0f)
        {
            Die();
        }

    }

    void Die()
    {
        PlayerPrefs.SetInt("G3Kill", PlayerPrefs.GetInt("G3Kill", 0) + 1);
        Destroy(gameObject);
        Instantiate(explotion, transform.position, Quaternion.identity);
    }
}
