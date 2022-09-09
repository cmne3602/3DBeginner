using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChasePlayer : MonoBehaviour {
    public NavMeshAgent navMeshAgent;
    public Transform player;
    public GhostStates ghostStates;
    public bool isCoolTime = false;

    private const float CHASING_TIME = 4f;
    private float curTime = CHASING_TIME;

    private const float COOL_TIME = 3f;
    private float coolTime = COOL_TIME;

    public void Chase() {
        navMeshAgent.speed = 1f;
        navMeshAgent.SetDestination(player.position);
        curTime -= Time.deltaTime;
        if (curTime < 0) {
            ghostStates.SetStates(States.Idle);
            navMeshAgent.SetDestination(transform.position);
            navMeshAgent.speed = 3f;
            curTime = CHASING_TIME;
            isCoolTime = true;
        }
    }

    private void Update() {
        if (isCoolTime) {
            coolTime -= Time.deltaTime;
            if (coolTime < 0) {
                coolTime = COOL_TIME;
                isCoolTime = false;
            }
        }
    }
}
