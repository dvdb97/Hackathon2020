using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCGunController : MonoBehaviour
{
    public GunController gc;
    public float cooldown = 1f;
    private float currentCooldown = 0f;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            currentCooldown -= Time.fixedDeltaTime;

            if (currentCooldown <= 0f)
            {
                gc.Fire(other.transform.position - transform.position);
                currentCooldown = cooldown;
            }
        }
    }

}
