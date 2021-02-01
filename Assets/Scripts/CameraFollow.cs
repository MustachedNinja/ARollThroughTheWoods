using UnityEngine;

public class CameraFollow : MonoBehaviour {

    [SerializeField]
    private Vector3 offset;
    private Transform target;
    [SerializeField]
    private float smoothSpeed = 0.125f;

    public void SetTarget(Transform target) {
        this.target = target;
    }

    void LateUpdate() {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;

        // transform.rotation = Quaternion.Euler(90, 0, 0);
        transform.LookAt(target);
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, 0, transform.rotation.eulerAngles.z);
    }
}