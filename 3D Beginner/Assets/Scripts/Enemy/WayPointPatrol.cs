using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WayPointPatrol : MonoBehaviour {
    public NavMeshAgent navMeshAgent;
    public Transform[] wayPoints;

    int m_CurrentWayPointIndex = 0;

    void Start() {
        navMeshAgent.SetDestination(wayPoints[0].position);
    }

    public void Move() {
        if (navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance) {
            m_CurrentWayPointIndex = (m_CurrentWayPointIndex + 1) % wayPoints.Length;
            navMeshAgent.SetDestination(wayPoints[m_CurrentWayPointIndex].position);
        }
    }
}
