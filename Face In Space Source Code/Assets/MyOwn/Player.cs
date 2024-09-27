using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxSpeed = 15;
    private Rigidbody2D rgbody;

    void Start()
    {
        rgbody = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(rgbody.velocity.magnitude > maxSpeed)
        {
            rgbody.velocity = rgbody.velocity.normalized * maxSpeed;
        }
    }
}
