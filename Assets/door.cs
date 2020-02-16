using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public float posX = 5.55f;
    public bool x, z = false;
    Vector3 Mypos = Vector3.zero;

    void Start()
    {
        Mypos = transform.position;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            transform.position = Mypos;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
                StartCoroutine(CreateEne());
        }
    }

    IEnumerator CreateEne()
    {
        float movePos = 0.5f;
        Vector3 pos = transform.position;
        for (int i = 0; i < 4; i++)
        {
            yield return new WaitForSeconds(1);
            transform.position = pos;
            if(x)
                pos.x += movePos;
            else if (z)
                pos.z += movePos;
        }

    }
}
