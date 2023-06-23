using System.Collections;
using UnityEngine;

public class FireBullet : Bullet
{
    public override IEnumerator DoShoot()
    {
        _rb.velocity = _targetVector * BulletSpeed;
        yield return new WaitForSeconds(BulletLifeTime);
        Destroy(gameObject);
    }

    public override void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag != "Player")
        {
            Debug.Log("Fire Hit!!");
            //Damage
            Destroy(gameObject);
        }
    }
}
