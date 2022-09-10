using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFearness : MonoBehaviour {
    public FearnessCollider fearnessCollider;
    private PlayerMovement playerMovement;
    private float fearnessSpeed;

    private void Start() {
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update() {
        if (fearnessCollider.GetNumOfEnemies() != 0) {
            fearnessSpeed = SetFearnessSpeed();
            playerMovement.SetMoveSpeed(fearnessSpeed);
        }
        else
            playerMovement.SetMoveSpeed(1.3f);
    }

    private float SetFearnessSpeed() {
        float fearnessSpeed = 0.5f + fearnessCollider.GetDistanceFromNeariestEnemy() * 0.1f;
        if (GameManager.isFriendwithGhost)
            fearnessSpeed = (fearnessSpeed < 0.9f) ? 0.9f : fearnessSpeed;
        return fearnessSpeed;
    }
}
