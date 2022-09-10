using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowWorld : MonoBehaviour {
    public Transform lookAt;
    public Vector3 offset;
    private Camera cam;

    private void Start() {
        cam = Camera.main;
    }

    private void Update() {
        Vector3 position = cam.WorldToScreenPoint(lookAt.position + offset);

        if(transform.position != position)
            transform.position = position;
    }

    public void ChangeLookAt(Transform next) {
        lookAt = next;
    }
}
