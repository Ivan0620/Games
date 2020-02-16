using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonView : MonoBehaviour
{
    private Rigidbody rb;

    public float rotationSpeed = 3f;
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    private Vector3 moveDirection = Vector3.zero;
    private Vector3 moveRotation = Vector3.zero;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Move();
        Rotation();
    }

    void Move()
    {
        rb.MovePosition(rb.position + moveDirection * Time.fixedDeltaTime);
    }

    void Rotation()
    {
        rb.MoveRotation(rb.rotation * Quaternion.Euler(moveRotation));
    }

    void Update()
    {
        float xMov = Input.GetAxisRaw("Horizontal");
        float zMov = Input.GetAxisRaw("Vertical");

        Vector3 movHorizontal = transform.right * xMov;
        Vector3 movVertical = transform.forward * zMov;

        Vector3 velocity = (movHorizontal + movVertical).normalized * speed;

        if (Input.GetButtonDown("Jumps"))
        {
            velocity.y += jumpSpeed;
        }

        moveDirection = velocity;
        velocity.y *= gravity;



        float yRot = Input.GetAxisRaw("Mouse X");

        Vector3 rotation = new Vector3(0f, yRot, 0f) * rotationSpeed;

        moveRotation = rotation;
    }

}
