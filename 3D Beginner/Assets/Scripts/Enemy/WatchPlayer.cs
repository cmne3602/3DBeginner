using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WatchPlayer : MonoBehaviour {
    public NavMeshAgent navMeshAgent;
    public Transform player;

    public void Watch() {
        navMeshAgent.speed = 0.1f;
        navMeshAgent.SetDestination(player.position);
    }
}
