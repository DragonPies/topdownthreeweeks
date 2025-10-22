using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnHitbox : MonoBehaviour
{
    public float attackRadius = 1.5f;
    public LayerMask attackLayer;

    private TopDownMovement topDown;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        topDown = GetComponent<TopDownMovement>();
    }

    private void OnValidate()
    {
        topDown = GetComponent<TopDownMovement>();
    }


    public void Attack(InputAction.CallbackContext ctx)
    {
        if (ctx.ReadValue<float>() == 0)
            return;

        RaycastHit2D hit = Physics2D.CircleCast(transform.position + (Vector3)topDown.direction, attackRadius, Vector2.zero, 0, attackLayer);

        if (hit)
        { 
            Debug.Log(hit.collider.gameObject.name);
            
            if (hit.collider.TryGetComponent(out Stats targetStats) && TryGetComponent(out Stats playerStats))
            {
               float calculatedDamage = playerStats.damage - targetStats.defense;
                targetStats.currentHealth -= calculatedDamage;
            }
        }
    }

   private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position + (Vector3)topDown.direction, attackRadius);
    }
}
