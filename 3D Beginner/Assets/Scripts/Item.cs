using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {
    private float rotationSpeed = 100f;

    private void Update() {
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed, Space.World);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            Destroy(gameObject);
        }
    }
}
