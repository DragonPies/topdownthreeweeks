using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject startingEnemy; // The initial enemy prefab to spawn
    public float coolDown = 5f;

    private float timer;
    private int spawnCount = 1;
    private int spawner = 1;
    private float difficultyMultiplier = 1.2f;

    private void Start()
    {
        timer = coolDown;
        for (int i = 0; i < 1; i++)
        {
            SpawnEnemy();
        }
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0) { 
            for (int i = 0; i < spawnCount; i++)
            {
                SpawnEnemy();
            }
            spawnCount += spawner;
            timer = coolDown *= difficultyMultiplier;

        }
    }

    void SpawnEnemy()
    {
        Instantiate(startingEnemy, transform.position, transform.rotation);
    }
}