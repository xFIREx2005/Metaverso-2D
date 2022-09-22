using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    protected SpriteRenderer sprEnemy;
    protected NavMeshAgent agent;

    public GameObject posDes;

    protected float life;
    protected float speed;
    protected float stopDis;

    private void Start()
    {
        
    }

    private void Update()
    {
    }

    public void Move()
    {
        agent.SetDestination(posDes.transform.position);
        agent.stoppingDistance = stopDis;
        agent.speed = speed;
        transform.eulerAngles = new Vector3(0, 0, 0);
    }

    public void DamageEnemy(int damageBullet)
    {
        life -= damageBullet;
        StartCoroutine(Damage());
        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator Damage()
    {
        sprEnemy.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        sprEnemy.color = Color.white;
    }
}
