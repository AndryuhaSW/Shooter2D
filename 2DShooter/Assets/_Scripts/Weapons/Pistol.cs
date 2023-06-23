using System.Collections;
using UnityEngine;

public class Pistol : Weapon
{
    public override IEnumerator DoShoot(Vector2 targetPoint)
    {
        Vector2 cursorWorldPosition = (Vector2)Camera.main.ScreenToWorldPoint(targetPoint);
        Vector2 shootVector = cursorWorldPosition - (Vector2)BulletSpawnPoint.position;
        shootVector.Normalize();

        GameObject bulletGameObject = Instantiate(BulletPrefab, BulletSpawnPoint.position, new Quaternion(0, 0, 0, 0));
        Bullet bullet = bulletGameObject.GetComponent<Bullet>();
        bullet.Initialize(shootVector);
        
        yield break;
    }
}
