
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createEnemy : MonoBehaviour
{
    public GameObject[] enemy;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateEne());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator CreateEne()
    {
        int rand = Random.Range(0, enemy.Length);
        yield return new WaitForSeconds(2);
        Debug.Log("CreateEne Runing" + rand);
        Instantiate(enemy[rand], transform.position, Quaternion.identity);
        StartCoroutine(CreateEne());
    }
}
