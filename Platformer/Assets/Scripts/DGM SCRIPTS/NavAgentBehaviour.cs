using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavAgentBehaviour : MonoBehaviour
{
    private NavMeshAgent agent;
    public Vector3 location;
    public Transform player;
    public float speed = 4f;
    private Transform currentDestination;
    private bool isInTrigger = false;
    private int i = 0;

    public List<Transform> patrolPoints;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        currentDestination = transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        currentDestination = player;
        isInTrigger = true;
        speed = 7f;
    }

    private void OnTriggerExit(Collider other)
    {
        currentDestination = transform;
        isInTrigger = false;
        speed = 4f;
    }

    // Update is called once per frame
    void Update()
    {
        agent.speed = speed;

        if(isInTrigger)
        {
            agent.destination = currentDestination.position;
            return;
        }

        if(!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            agent.destination = patrolPoints[i].position;
            i = (i + 1) % patrolPoints.Count;
        }

        transform.LookAt(agent.destination);
    }
}
