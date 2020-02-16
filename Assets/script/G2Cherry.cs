using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class G2Cherry : MonoBehaviour
{
    public TextMeshProUGUI ArrOfCherry;
    public string CherryName;
    int numCherry = 0;
    // Start is called before the first frame update
    void Start()
    {
        ArrOfCherry = GameObject.FindGameObjectWithTag(CherryName).GetComponent<TextMeshProUGUI>();
        if (ArrOfCherry == null)
            Debug.Log("Error");
        Destroy(gameObject, 5);
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
            numCherry = PlayerPrefs.GetInt(CherryName, 0) - 1;
            PlayerPrefs.SetInt(CherryName, numCherry);
            ArrOfCherry.text = numCherry.ToString();
        }
    }
}
