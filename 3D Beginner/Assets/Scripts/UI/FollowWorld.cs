using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowWorld : MonoBehaviour {
    public Transform lookAt;
    public Vector3 offset;
    private Camera cam;

    void Start() {
        cam = Camera.main;
    }

    void Update() {
        Vector3 position = cam.WorldToScreenPoint(lookAt.position + offset);

        if(transform.position != position)
            transform.position = position;
    }
}
