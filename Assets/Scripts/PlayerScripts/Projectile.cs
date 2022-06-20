using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    Rigidbody bulletrb;

    public GameObject ammo;
    public float launchForce = 30f;
    public Transform olusumNoktasi;

    void Start()
    {
        bulletrb = GetComponent<Rigidbody>();
        bulletrb.velocity = transform.forward * launchForce;
    }

    void Update() { }
}
