using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 10;
    public Rigidbody2D rb;
    public GameObject impactEffect;
    public GameObject player;
    private float BulletTime;

    

    void Start()
    {
        rb.velocity = transform.right * speed;
        BulletTime = 2.5F;
    }

    void Update()
    {
        BulletTime -= Time.deltaTime;
        if(BulletTime <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        HealthSystem player = hitInfo.GetComponent<HealthSystem>();
        if (BulletTime > 0 && player != null && player.gameObject != this.player)
        {
            player.TakeDamage(damage);
            // Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
