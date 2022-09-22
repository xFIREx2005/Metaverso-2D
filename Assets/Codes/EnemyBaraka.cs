using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBaraka : EnemyController
{
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        sprEnemy = GetComponent<SpriteRenderer>();
        life = 9;
        speed = 2.5f;
    }

    private void Update()
    {
        Move();
    }
}
