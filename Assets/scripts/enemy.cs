using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{

    public GameObject target;
    NavMeshAgent agent;

    public float distanceEnemyToPlayer = 6;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if(target == null)
        {
            target = GameObject.FindGameObjectWithTag("Player");
        }
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distance = Vector3.Distance(target.transform.position, agent.transform.position);


        if (distance < distanceEnemyToPlayer)
        {
            agent.destination = target.transform.position;
        } else
        {
            agent.destination = agent.transform.position;
        }
        
    }
}
