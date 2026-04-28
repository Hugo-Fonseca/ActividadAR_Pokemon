using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Transform spawnArea;
    public float spawnHeight = 3f; // Altura a la que se generarán los obstáculos
    public float spawnRate = 1.5f; // Tiempo entre cada generación de obstáculos

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
        Collider areaCollider = spawnArea.GetComponent<Collider>();
        Bounds bounds = areaCollider.bounds;

        float randomX = Random.Range(bounds.min.x, bounds.max.x);
        float randomZ = Random.Range(bounds.min.z, bounds.max.z);

        Vector3 spawnPosition = new Vector3(
            randomX,
            bounds.max.y + spawnHeight,
            randomZ
        );

        Instantiate(
            obstaclePrefab,
            spawnPosition,
            Quaternion.identity,
            spawnArea
        );
    }
}