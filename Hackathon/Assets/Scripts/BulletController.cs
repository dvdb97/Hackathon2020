using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public Transform creater;
    public Rigidbody rb;

    public Vector3 direction;
    public float speed = 1;

    public float lifetime = 10;

    void Start()
    {
        direction = Vector3.Normalize(direction);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        lifetime -= Time.fixedDeltaTime;

        if (lifetime <= 0)
        {
            Destroy(gameObject);
        }

        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.transform != creater)
        {
            Destroy(gameObject);
        }
    }
    
}
