using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class nextScene : MonoBehaviour
{
    public int sceneNum = 0;
    public int nextLv;
    public string valName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Time.timeScale = 1f;
            PlayerPrefs.SetInt(valName, nextLv);
            SceneManager.LoadScene(sceneNum);
        }
    }
}
