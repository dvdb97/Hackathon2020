using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleController : MonoBehaviour
{
    public Transform creater;
    public float lifetime = 2f;

    // Update is called once per frame
    void FixedUpdate()
    {
        lifetime -= Time.fixedDeltaTime;

        if (lifetime <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        BulletController bulletController = col.gameObject.GetComponent<BulletController>();

        if (bulletController != null)
        {
            Debug.Log("Bullet!");
            Destroy(col.gameObject);
        }
    }
}
