using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaffController : MonoBehaviour
{
    public GameObject bubble;
    public Transform playerTransform;

    public float cooldown = 5f;
    private float remainingCooldown = 0f;

    public void FixedUpdate()
    {
        remainingCooldown -= Time.fixedDeltaTime;

        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (remainingCooldown <= 0f)
            {
                GameObject bubbleObject = Instantiate(bubble, playerTransform);
                BubbleController bubbleController = bubbleObject.GetComponent<BubbleController>();
                bubbleController.creater = playerTransform;
                remainingCooldown = cooldown;
            }
        }
    }
}
