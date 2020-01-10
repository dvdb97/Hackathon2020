using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultGun : GunController
{
    public override void Fire()
    {
        ShootBullet(GetAimDirection());
    }


    public override void Fire(Vector3 direction)
    {
        ShootBullet(direction);
    }
}
