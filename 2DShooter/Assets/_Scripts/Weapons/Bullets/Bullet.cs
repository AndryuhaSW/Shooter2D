using System.Collections;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
     [field: SerializeField] public int Damage { get; set; }
     [field: SerializeField] public float BulletLifeTime { get; set; }
     [field: SerializeField] public float BulletSpeed { get; set; }

     protected Rigidbody2D _rb;
     protected Vector2 _targetVector;

     public void Initialize(Vector2 targetPoint)
     {
          _rb = GetComponent<Rigidbody2D>();
          _targetVector = targetPoint;
          StartCoroutine(DoShoot());
     }

     public abstract IEnumerator DoShoot();
     public abstract void OnTriggerEnter2D(Collider2D other);

}
