using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FearnessCollider : MonoBehaviour {
    public GameObject player;
    
    private int numOfEnemies = 0;
    private float distanceFromNeariestEnemy = 3f;
    private List<GameObject> nearEnemies = new List<GameObject>();

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Enemies")) {
            nearEnemies.Add(other.gameObject);
            numOfEnemies++;
        }
    }

    private void OnTriggerStay(Collider other) {
        if (other.CompareTag("Enemies")) {
            distanceFromNeariestEnemy = SetDistanceFromNeariestEnemy();
        }
    }

    private float SetDistanceFromNeariestEnemy() {
        List<float> distances = new List<float>();
        Vector3 v;
        for (int i = 0; i < nearEnemies.Count; i++) {
            v = nearEnemies[i].transform.position - player.transform.position;
            distances.Add(v.magnitude);
        }

        float min = float.MaxValue;
        foreach (float f in distances) {
            if (f < min)
                min = f;
        }
        return min;
    }

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Enemies")) {
            nearEnemies.Remove(other.gameObject);
            numOfEnemies--;
        }
    }

    private void Update() {
        if (numOfEnemies == 0)
            distanceFromNeariestEnemy = 3f;
    }

    public int GetNumOfEnemies() {
        return numOfEnemies;
    }

    public float GetDistanceFromNeariestEnemy() {
        return distanceFromNeariestEnemy;
    }
}
