using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Transform spawnArea;
    public float spawnHeight = 3f;
    public float spawnRate = 2f;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnRate)
        {
            SpawnObstacle();
            timer = 0;
        }
    }

    void SpawnObstacle()
    {
        Vector3 areaSize = spawnArea.localScale;

        float randomX = Random.Range(-areaSize.x / 2, areaSize.x / 2);
        float randomZ = Random.Range(-areaSize.z / 2, areaSize.z / 2);

        Vector3 spawnPosition =
            spawnArea.position +
            new Vector3(randomX, spawnHeight, randomZ);

        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
    }
}
