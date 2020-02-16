using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class HideTilemapColliderOnPlay : MonoBehaviour
{
    private Renderer colliderRenderer;
    private Transform tile;
    public float speed = 0.01f;

    void Start()
    {
        colliderRenderer = GetComponent<Renderer>();
        tile = GetComponent<Transform>();
        //colliderRenderer.enabled = false;
    }

    private void FixedUpdate()
    {
        Vector3 pos = tile.position;
        pos.x += speed;
        tile.SetPositionAndRotation(pos, Quaternion.identity);
    }
}
