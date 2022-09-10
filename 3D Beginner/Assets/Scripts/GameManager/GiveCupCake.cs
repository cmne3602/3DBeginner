using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class GiveCupCake : MonoBehaviour {
    public Transform ghost;
    public GameObject ui;

    private bool moveUp = false;

    private void OnTriggerEnter(Collider other) {
        if (!other.CompareTag("Player") || !GameManager.gotCupCake)
            return;

        ui.SetActive(true);
    }

    private void OnTriggerStay(Collider other) {
        if (!other.CompareTag("Player") || !GameManager.gotCupCake)
            return;
        if (Input.GetKeyDown(KeyCode.Space))
            GiveGhostCupCake();
    }

    private void GiveGhostCupCake() {
        ui.GetComponent<TextMeshProUGUI>().text = "Thank you ..";
        moveUp = true;
        GameManager.isFriendwithGhost = true;
    }

    private void Update() {
        if(moveUp)
            ghost.position = new Vector3(ghost.position.x, ghost.position.y + 0.7f * Time.deltaTime, ghost.position.z);
    }

    private void OnTriggerExit(Collider other) {
        if (!other.CompareTag("Player") || !GameManager.gotCupCake)
            return;

        ui.SetActive(false);
    }
}
