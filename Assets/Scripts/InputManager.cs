using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[Serializable]
public class TiltInputEvent : UnityEvent<float, float> {}
[Serializable]
public class PauseInputEvent : UnityEvent<bool> {}

public class InputManager : MonoBehaviour
{
    Controls controls;
    public TiltInputEvent tiltInputEvent;
    public PauseInputEvent pauseInputEvent;

    private void Awake() {
        controls = new Controls();
    }

    private void OnEnable() {
        controls.Player.Enable();
        controls.UI.Enable();
        controls.Player.Tilt.performed += OnTiltPerformed;
        controls.UI.Pause.performed += OnPausePerformed;
    }

    private void OnTiltPerformed(InputAction.CallbackContext context) {
        // Debug.Log(context.ReadValue<Vector2>().ToString());
        Vector2 tiltInput = context.ReadValue<Vector2>();
        tiltInputEvent.Invoke(tiltInput.x, tiltInput.y);
    }

    private void OnPausePerformed(InputAction.CallbackContext context) {
        if (controls.Player.enabled) {
            controls.Player.Disable();
        } else {
            controls.Player.Enable();
        }
        pauseInputEvent.Invoke(true);
    }
}