using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private GameObject projectile;
    private MouseLook MouseLook;
    public GameObject olusumNoktasi;
    public Transform gunBody;
    private float lastShot = 0f;

    private float fireRate = 0.1f;
    float xRotation = 0f;
    public float mouseSens = 100f;

    void Start()
    {
        MouseLook = GetComponent<MouseLook>();
    }

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Fire();
        }
        mouseLook();
    }

    void Fire()
    {
        if (Time.time > fireRate + lastShot)
        {
            Instantiate(projectile, olusumNoktasi.transform.position, transform.rotation);
            lastShot = Time.time;
        }
    }

    public void mouseLook()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        gunBody.Rotate(Vector3.up * mouseX);
    }
}
