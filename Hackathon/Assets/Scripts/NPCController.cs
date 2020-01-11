using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    public int hp = 100;
    public float speed = 1f;

    public Transform[] points = new Transform[4];

    private float distance;
    private Vector3 direction;
    private Vector3 nextDestination;

    public GunController gc;
    public Rigidbody rb;

    public void Start()
    {
        ChooseDestination();
    }

    public void ChooseDestination()
    {
        Vector3 result = new Vector3(0f, 0f, 0f);

        for (int i = 0; i < 4; i++)
        {
            result += Random.Range(-1f, 1f) * points[i].position;
        }

        nextDestination = result;
        Debug.Log(result);
        direction = Vector3.Normalize(nextDestination - rb.position);
        distance = (nextDestination - rb.position).magnitude;
    }

    public void FixedUpdate()
    {
        if (hp <= 0)
        {
            Destroy(gameObject);
        }

        if (distance > 0f)
        {
            Debug.Log("Moving!");
            rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
            distance -= speed * Time.fixedDeltaTime;
        }
        else
        {
            ChooseDestination();
        }
    }

}
