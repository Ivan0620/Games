using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killZon : MonoBehaviour
{
    public GameObject obj;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            Time.timeScale = 0f;
            obj.SetActive(true);
        }
        else
            Debug.Log("Erorr");
    }
}
