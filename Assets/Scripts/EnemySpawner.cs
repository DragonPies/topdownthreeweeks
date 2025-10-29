using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy; // The enemy prefab to spawn
    public float spawnInterval = 2f; // Time interval between spawns
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnEnemy();
            timer = 0f;
        }
    }

    void SpawnEnemy()
    {
        Instantiate(enemy, transform.position, transform.rotation);
    }
}