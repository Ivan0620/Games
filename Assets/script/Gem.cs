using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            Destroy(gameObject);

            PlayerPrefs.SetInt("GemNum", PlayerPrefs.GetInt("GemNum") + 1);
        }
        else
            Debug.Log("Erorr");
    }
}
