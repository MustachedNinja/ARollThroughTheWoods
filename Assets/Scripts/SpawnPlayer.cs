using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    [SerializeField]
    private GameObject playerPrefab;
    void Start()
    {
        Instantiate(playerPrefab, transform.position, Quaternion.identity);
    }
}
