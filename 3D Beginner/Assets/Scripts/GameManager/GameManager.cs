using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameManager {
    public static string playerName;
    public static int coin = 0;
    public static int rustKey = 0;
    public static float time = 0;
    public static int chased = 0;

    public static bool gotHiddenKey = false;
    public static bool gotCupCake = true;
    public static bool isFriendwithGhost = false;
    public static bool isSecretDoorOpenable = true;
    public static bool isGameOver = false;
    public static int score = 0;

    private static void Update() {
        if(!isGameOver)
            time += Time.deltaTime;
    }

    public static void GotCoin() {
        coin++;
    }

    public static void GotRustKey() {
        rustKey++;
        if (rustKey == 3)
            isSecretDoorOpenable = true;
    }

    public static void GotHiddenKey() {
        gotHiddenKey = true;
    }

    public static void GotCupCake() { 
        gotCupCake = true;
    }
}
