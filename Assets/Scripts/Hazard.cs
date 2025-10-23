using UnityEngine;

public class Hazard : MonoBehaviour
{
    public float hazardDamage = 2f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Stats stats))
        {
            stats.currentHealth -= hazardDamage;
        }
    }
}
