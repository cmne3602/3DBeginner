using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSightCollider : MonoBehaviour {
    public GhostStates ghostStates;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player"))
            ghostStates.SetStates(States.Chase);
    }
}
