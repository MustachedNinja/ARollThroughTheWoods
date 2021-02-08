using UnityEngine;
using UnityEngine.InputSystem;

public class PauseControl : MonoBehaviour {
    public static bool isPaused = false;
    private static bool prevPaus = false;

    [SerializeField]
    private GameObject pauseMenuUI;
    [SerializeField]
    private GameObject hudUI;

    public InputActionAsset inputAsset;
    private InputActionMap playerMap;
    private InputActionMap uiMap;

    private void Awake() {
        playerMap = inputAsset.FindActionMap("Player");
        uiMap = inputAsset.FindActionMap("UI");
    }

    public void TogglePause() {
        if (isPaused) {
            Debug.Log("RESUME");
            Resume();
        } else {
            Debug.Log("PAUSE");
            Pause();
        }
    }

    void Pause() {
        hudUI.SetActive(false);
        pauseMenuUI.SetActive(true);
        isPaused = true;
        Time.timeScale = 0f;
        playerMap.Disable();
        uiMap.Disable();
    }

    void Resume() {
        hudUI.SetActive(true);
        pauseMenuUI.SetActive(false);
        isPaused = false;
        Time.timeScale = 1f;
        playerMap.Enable();
        uiMap.Disable();
    }

}
