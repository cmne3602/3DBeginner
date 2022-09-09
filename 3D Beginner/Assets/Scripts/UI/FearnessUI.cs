using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FearnessUI : MonoBehaviour {
    public Slider fearnessBar;
    public PlayerMovement playerMovement; 

    private void Update() {
        fearnessBar.value = 1.3f - playerMovement.GetMoveSpeed();
    }
}
