using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroyIfEnemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D enemy)
    {
        if (enemy.gameObject.CompareTag("enemy"))
        {
            Destroy(gameObject);
            Destroy(enemy.gameObject);
        }
    }
}
