using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{
    private NavMeshAgent agent;
    private float minZ = -7.56f, maxZ = 18.14f;
    private float minX = -20.89f , maxX = 6;
    private float offset = 2;
    void Start()
    {
       agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
       if(agent.pathPending || !agent.isOnNavMesh || agent.remainingDistance > offset)
       {
            return;
       }
       agent.SetDestination(GenerateRandomPosition());
    }
    private Vector3 GenerateRandomPosition()
    {
        return new Vector3(Random.Range(minX,maxX),transform.position.y, Random.Range(minZ,maxZ));
    }
}