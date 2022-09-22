using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMoscow : EnemyController
{
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        sprEnemy = GetComponent<SpriteRenderer>();
        life = 3;
        speed = 4;
    }

    private void Update()
    {
        Move();   
    }
}
