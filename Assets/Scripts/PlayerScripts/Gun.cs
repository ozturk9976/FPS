using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private GameObject projectile;
    public GameObject olusumNoktasi;

    void Start() { }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < 1; i++)
            {
                Instantiate(projectile, olusumNoktasi.transform.position, transform.rotation);
            }
        }
    }
}
