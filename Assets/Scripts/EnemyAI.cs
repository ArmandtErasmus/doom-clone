using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private EnemyAwareness enemyAwareness;
    private Transform playersTransform;

    private UnityEngine.AI.NavMeshAgent enemyNavMeshAgent;

    private void Start()
    {
        enemyAwareness = GetComponent<EnemyAwareness>();
        playersTransform = FindObjectOfType<PlayerMove>().transform;
        enemyNavMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    private void Update()
    {
        if (enemyAwareness.isAggro)
        {
           enemyNavMeshAgent.SetDestination(playersTransform.position); 
        }
        else
        {
            enemyNavMeshAgent.SetDestination(transform.position);
        }
    }

}
