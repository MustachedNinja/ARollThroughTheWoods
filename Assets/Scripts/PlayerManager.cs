using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    private CameraFollow cameraPrefab;
    void Awake() {
        CameraFollow camera = Instantiate(cameraPrefab, transform.position, Quaternion.identity);
        camera.SetTarget(this.transform);
    }
}
