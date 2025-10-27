using Unity.VisualScripting;
using UnityEngine;

public class ManaRegen : MonoBehaviour
{
    private float timer;
    private Stats currentStats;

    public float coolDown = 1f;
    public float manaRegenAmount = 5f;
   
    // Update is called once per frame
    void Update()
    {
        if (TryGetComponent(out Stats stats))
        {
            currentStats = stats;
        }
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            currentStats.currentMana += manaRegenAmount;
            timer = coolDown;
        }
    }
}
