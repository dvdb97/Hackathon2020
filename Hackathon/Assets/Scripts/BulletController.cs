using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public Rigidbody rb;

    public Vector3 direction;
    public float speed = 1;
    public int dmg = 20;

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
        NPCController npcController = col.gameObject.GetComponent<NPCController>();

        if (npcController != null)
        {
            npcController.hp -= dmg;
            Debug.Log("NPC hit!");
        }

        PlayerController playerController = col.gameObject.GetComponent<PlayerController>();

        if (playerController != null)
        {
            playerController.hp -= dmg;
            Debug.Log("Enemy hit!");
        }

        Destroy(gameObject);
    }
    
}
