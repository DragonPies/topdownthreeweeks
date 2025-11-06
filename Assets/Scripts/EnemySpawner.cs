using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject startingEnemy; // The initial enemy prefab to spawn
    public float coolDown = 2f;

    private float timer;
    private int spawnCount = 1;
    private int spawner = 1;
    private float difficultyMultiplier = 1.35f;

    private void Start()
    {
        timer = coolDown;
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