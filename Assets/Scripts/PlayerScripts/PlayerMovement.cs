using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float turningSpeed = 25f;

    void Start() { }

    void Update()
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
    }
}
