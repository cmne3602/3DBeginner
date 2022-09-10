using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum States {Idle, Chase, Friendly }

public class GhostStates : MonoBehaviour {
    public WayPointPatrol wayPointPatrol;
    public ChasePlayer chasePlayer;
    public WatchPlayer watchPlayer;
    public GameObject pointOfView;

    private bool isCoolTime;

    [SerializeField]
    private States curStates;

    private void Start() {
        curStates = States.Idle;
    }

    private void Update() {
        if (GameManager.isFriendwithGhost) {
            curStates = States.Friendly;
            pointOfView.SetActive(false);
        }

        if (curStates == States.Chase && !chasePlayer.isCoolTime)
            chasePlayer.Chase();
        else if (curStates == States.Friendly)
            watchPlayer.Watch();
        else
            wayPointPatrol.Move();
    }

    public void SetStates(States states) {
        curStates = states;
    }
}
