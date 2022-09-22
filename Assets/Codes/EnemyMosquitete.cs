using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMosquitete : EnemyController
{
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        sprEnemy = GetComponent<SpriteRenderer>();
        life = 4;
        speed = 3;
    }

    private void Update()
    {
        Move();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerController player = collision.GetComponent<PlayerController>();
            if (player != null)
            {
                player.DamageEnemy(1);
                Destroy(gameObject);
            }

        }
    }
}
