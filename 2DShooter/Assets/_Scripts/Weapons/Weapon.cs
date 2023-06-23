using System.Collections;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [field: SerializeField] public float PrepareTime { get; set; }
    [field: SerializeField] public GameObject BulletPrefab { get; set; }
    [field: SerializeField] public Transform BulletSpawnPoint { get; set; }

    public abstract IEnumerator DoShoot(Vector2 targetPoint);
}

