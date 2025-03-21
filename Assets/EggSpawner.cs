using UnityEngine;

public class EggSpawner : MonoBehaviour
{
    [SerializeField] private GameObject eggPrefab; // Prefab trứng
    [SerializeField] private Transform spawnPoint; // Vị trí sinh trứng
    [SerializeField] private float spawnInterval = 2f; // Thời gian giữa mỗi lần sinh

    private void Start()
    {
        InvokeRepeating(nameof(SpawnEgg), 0f, spawnInterval);
    }

    void SpawnEgg()
    {
        if (eggPrefab != null && spawnPoint != null)
        {
            Instantiate(eggPrefab, spawnPoint.position, Quaternion.identity);
        }
    }
}