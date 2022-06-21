using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private GameObject projectile;
    public GameObject olusumNoktasi;
    private float lastShot = 0f;

    private float fireRate = 0.1f;

    void Start() { }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Fire();
        }
    }

    void Fire()
    {
        if (Time.time > fireRate + lastShot)
        {
            Instantiate(projectile, olusumNoktasi.transform.position, transform.rotation);
            lastShot = Time.time;
        }
    }
}
