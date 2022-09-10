using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSecretDoor : MonoBehaviour {
    public GameObject secretDoor;
    public GameObject ui;
    public Transform hiddenDoor;

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
        Debug.Log("Opened");
        ui.GetComponent<FollowWorld>().ChangeLookAt(hiddenDoor);
        ui.SetActive(false);
        Destroy(secretDoor);
    }

    private void OnTriggerExit(Collider other) {
        if (!other.CompareTag("Player") || !GameManager.isSecretDoorOpenable)
            return;

        ui.SetActive(false);
    }
}
