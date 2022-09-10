using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {
    private float rotationSpeed = 100f;

    private void Update() {
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed, Space.World);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {

            if (this.CompareTag("Coin"))
                GameManager.GotCoin();
            else if (this.CompareTag("RustKey"))
                GameManager.GotRustKey();
            else if (this.CompareTag("HiddenKey"))
                GameManager.GotHiddenKey();
            else if (this.CompareTag("CupCake"))
                GameManager.GotCupCake();

            Destroy(gameObject);
        }
    }
}
