using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(Input.mousePosition);
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 20;

            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(mousePos);
            Vector3 direction = Vector3.Normalize(mouseWorldPos - transform.position);
            Debug.Log(direction.magnitude);

            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            bullet.transform.localScale = 0.5f * bullet.transform.localScale;
            BulletController bulletController = bullet.GetComponent<BulletController>();
            bulletController.direction = direction;
        }
    }
}
