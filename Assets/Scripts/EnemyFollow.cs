using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform player; // Reference to the player's Transform
    public float moveSpeed = 2f; // Speed at which the enemy moves
    public float detectionRange = 5f; // Distance within which the enemy starts following

    void Update()
    {
        // Calculate the distance between the enemy and the player
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        // Check if the player is within detection range
        if (distanceToPlayer < detectionRange)
        {
            // Move towards the player
            Vector2 direction = (player.position - transform.position).normalized;
            transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
        }
    }
}