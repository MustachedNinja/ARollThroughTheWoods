using UnityEngine;
using UnityEngine.InputSystem;

public class GroundTiltControl : MonoBehaviour
{

    public void Tilt(InputAction.CallbackContext context) {
        Debug.Log("A tilt action is called");
    }
}
