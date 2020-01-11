using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform playerTransform;

    public float bulletLayer;

    public virtual void Fire()
    {

    }


    public virtual void Fire(Vector3 direction)
    {

    }


    public Vector3 GetAimDirection()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 20;

        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector3 direction = Vector3.Normalize(mouseWorldPos - transform.position);

        return direction;
    }


    public void ShootBullet(Vector3 direction)
    {
        Vector3 bulletPosition = new Vector3(transform.position.x, transform.position.y, bulletLayer);
        GameObject bullet = Instantiate(bulletPrefab, bulletPosition, Quaternion.identity);
        bullet.transform.localScale = 0.3f * bullet.transform.localScale;

        BulletController bulletController = bullet.GetComponent<BulletController>();
        bulletController.direction = new Vector3(direction.x, direction.y, 0f);
    }

}
