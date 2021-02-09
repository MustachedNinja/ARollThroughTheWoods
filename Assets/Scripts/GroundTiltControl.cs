using UnityEngine;

public class GroundTiltControl : MonoBehaviour
{

    float tiltX;
    float tiltY;

    [SerializeField]
    private float tiltMultiplier = 0.01f;
    [SerializeField]
    private float smoothSpeed = 0.1f;
    [SerializeField]
    private float xClamp = 20f;
    [SerializeField]
    private float zClamp = 20f;

    private Vector3 targetRotation;

    public void OnTiltInput(float x, float y) {
        Vector2 screenCenter = new Vector2(Screen.width / 2, Screen.height / 2);
        Vector2 delta = (new Vector2(x, y) - screenCenter);
        targetRotation = new Vector3(Mathf.Clamp(delta.y * tiltMultiplier, -xClamp, xClamp), 0, Mathf.Clamp(-delta.x * tiltMultiplier, -zClamp, zClamp));
    }

    // Use LateUpdate for smoothed out rotation
    // void LateUpdate() {
    //     Vector3 smoothedRotation = Vector3.Lerp(transform.rotation.eulerAngles, targetRotation, smoothSpeed);
    //     transform.rotation = Quaternion.Euler(smoothedRotation);
    // }

    // // Use Update for direct rotation
    void Update() {
        Vector3 smoothedRotation = Vector3.Lerp(transform.rotation.eulerAngles, targetRotation, smoothSpeed);
        transform.rotation = Quaternion.Euler(smoothedRotation);
    }

    // public void Tilt(InputAction.CallbackContext context) {
    //     Vector2 delta = (context.ReadValue<Vector2>() - new Vector2(Screen.width / 2, Screen.height / 2));
    //     targetRotation = new Vector3(Mathf.Clamp(delta.y * tiltMultiplier, -xClamp, xClamp), 0, Mathf.Clamp(-delta.x * tiltMultiplier, -zClamp, zClamp));
    // }
}