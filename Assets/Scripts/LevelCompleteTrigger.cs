using UnityEngine;

public class LevelCompleteTrigger : MonoBehaviour
{

    [SerializeField] GameObject levelCompleteUI;
    [SerializeField] GameObject hudUI;

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            CompleteLevel();
        }
    }

    private void CompleteLevel() {
        hudUI.SetActive(false);
        levelCompleteUI.SetActive(true);
    }
}
