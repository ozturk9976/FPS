using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 5f;
    public float turningSpeed = 25f;
    public float jumpHeight = 5f;
    public Vector3 jump;

    void Start()
    {
        jump = new Vector3(0.0f, 4.0f, 0.0f);
        rb = GetComponent<Rigidbody>();
    }

    void Update() { }

    void FixedUpdate()
    {
        float dikeyInput = Input.GetAxis("Vertical");
        float yatayInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(yatayInput, 0, dikeyInput) * (speed * Time.deltaTime));

        if (Input.GetKey(KeyCode.M))
        {
            transform.Rotate(Vector3.up * turningSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.N))
        {
            transform.Rotate(Vector3.down * turningSpeed * Time.deltaTime);
        }
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(jump * jumpHeight, ForceMode.Impulse);
        }
    }
}
