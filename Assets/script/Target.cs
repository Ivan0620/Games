using UnityEngine;

public class Target : MonoBehaviour
{
    public int health = 100;
    public int  Maxhealth = 100;
    public GameObject obj;
    public HpBar hpBar;

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
        Destroy(gameObject);
        Time.timeScale = 0f;
        obj.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }

}
