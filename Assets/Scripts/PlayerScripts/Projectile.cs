using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody bulletrb;

    public GameObject ammo;
    public GameObject particleEffect;
    public float launchForce = 30f;
    public Transform olusumNoktasi;

    [SerializeField]
    AudioSource projectileAudio;

    void Start()
    {
        bulletrb = GetComponent<Rigidbody>();
        bulletrb.velocity = transform.forward * launchForce;
        projectileAudio.Play();
        Destroy(gameObject, 3f);
    }

    void Update() { }

    void OnCollisionEnter(Collider col)
    {
        if (col.gameObject.tag.Equals("Thing"))
        {
            Instantiate(particleEffect, transform.position, transform.rotation);
        }
    }
}
