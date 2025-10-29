using System.Collections;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public GameObject targetObject;
    public float coolDown = 1f;
    private float timer;

    private float damage => targetObject.GetComponent<Stats>().damage;

    private Stats currentStats;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        currentStats = collision.gameObject.GetComponent<Stats>();

        timer = coolDown;
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        currentStats = null;
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (currentStats && timer <= 0)
        {
            currentStats.currentHealth -= damage - currentStats.defense;
            timer = coolDown;
        }
    }
}
