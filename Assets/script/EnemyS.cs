using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyS : MonoBehaviour
{
    public AIPath aiPath;
    public GameObject explotion;

    // Update is called once per frame
    void Update()
    {
        if (aiPath.desiredVelocity.x >= .01f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (aiPath.desiredVelocity.x <= -0.01f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Runing");
        if (collision.gameObject.tag == "player")
        {
            Destroy(gameObject);
            Instantiate(explotion, transform.position, Quaternion.identity);
        }
        else
            Debug.Log("Erorr");
    }
}
