using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum States {Idle, Chase}

public class GhostStates : MonoBehaviour {
    public WayPointPatrol wayPointPatrol;
    public ChasePlayer chasePlayer;

    private bool isCoolTime;

    [SerializeField]
    private States curStates;

    private void Start() {
        curStates = States.Idle;
    }

    private void Update() {
        if (curStates == States.Chase && !chasePlayer.isCoolTime)
            chasePlayer.Chase();
        else
            wayPointPatrol.Move();
    }

    public void SetStates(States states) {
        curStates = states;
    }
}
