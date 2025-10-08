using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Two
{
    
public class AIControl : MonoBehaviour {

    GameObject[] goalLocations;
    NavMeshAgent agent;

    void Start() 
    {
        agent = GetComponent<NavMeshAgent>();
        goalLocations = GameObject.FindGameObjectsWithTag("goal");
        int i = Random.Range(0, goalLocations.Lenght);
        agent.SetDestination(goalLocations[i].transform.position);
    }


    void Update() 
    {

    }
}
}