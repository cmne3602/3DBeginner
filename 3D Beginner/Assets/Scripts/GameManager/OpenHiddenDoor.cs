using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHiddenDoor : MonoBehaviour {
    public GameObject hiddenDoor;
    public GameObject ui;

    private void OnTriggerEnter(Collider other) {
        if (!other.CompareTag("Player") || !GameManager.isSecretDoorOpenable)
            return;

        ui.SetActive(true);
    }

    private void OnTriggerStay(Collider other) {
        if (!other.CompareTag("Player") || !GameManager.isSecretDoorOpenable)
            return;
        if (Input.GetKeyDown(KeyCode.Space))
            OpenDoor();
    }

    private void OpenDoor() {
        ui.SetActive(false);
        Destroy(hiddenDoor);
    }

    private void OnTriggerExit(Collider other) {
        if (!other.CompareTag("Player") || !GameManager.isSecretDoorOpenable)
            return;

        ui.SetActive(false);
    }
}
