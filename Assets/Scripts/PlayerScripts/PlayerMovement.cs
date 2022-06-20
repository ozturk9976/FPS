using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;

    void Start() { }

    void Update()
    {
        float dikeyInput = Input.GetAxis("Vertical");
        float yatayInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(yatayInput, 0, dikeyInput) * (speed * Time.deltaTime));
    }
}
