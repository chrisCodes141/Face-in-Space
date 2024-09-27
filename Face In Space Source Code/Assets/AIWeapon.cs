using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIWeapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public AudioSource shotsound;

    void Start()
    {
        shotsound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (true)
        {
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.GetComponent<Bullet>().player = gameObject;
        shotsound.Play();
    }
}