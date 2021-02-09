using UnityEngine;

public class PauseControl : MonoBehaviour {
    public static bool isPaused = false;

    [SerializeField]
    private GameObject pauseMenuUI;
    [SerializeField]
    private GameObject hudUI;

    public void TogglePause() {
        if (isPaused) {
            Resume();
        } else {
            Pause();
        }
    }

    void Pause() {
        hudUI.SetActive(false);
        pauseMenuUI.SetActive(true);
        isPaused = true;
        Time.timeScale = 0f;
    }

    void Resume() {
        hudUI.SetActive(true);
        pauseMenuUI.SetActive(false);
        isPaused = false;
        Time.timeScale = 1f;
    }

}
