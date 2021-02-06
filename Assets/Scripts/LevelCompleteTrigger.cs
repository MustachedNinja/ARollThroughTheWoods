﻿using UnityEngine;

public class LevelCompleteTrigger : MonoBehaviour
{

    [SerializeField] GameObject levelCompleteUI;

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            CompleteLevel();
        }
    }

    private void CompleteLevel() {
        levelCompleteUI.SetActive(true);
    }
}
