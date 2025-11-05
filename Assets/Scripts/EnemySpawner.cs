using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject startingEnemy; // The initial enemy prefab to spawn
    public GameObject enemy; // The enemy prefab to spawn
    public Stats stats; // Reference to the Stats script

    private int spawnCount = 1;

    private void Start()
    {
        Instantiate(startingEnemy, transform.position, transform.rotation);
        if (enemy == null && stats == null)
        {
            enemy = GameObject.FindWithTag("Enemy");
            stats = enemy.GetComponent<Stats>();
        }
    }

    void Update()
    {
        

        if (stats.isDead == true ) {
            Debug.Log("Enemy is Dead");
            for (int i = 0; i < spawnCount; i++)
            {
                Debug.Log("Enemy is spawning");
                SpawnEnemy();
                spawnCount++;
            }
                
            
        }
    }

    void SpawnEnemy()
    {
        Instantiate(enemy, transform.position, transform.rotation);
    }
}