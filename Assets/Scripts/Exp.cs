using UnityEngine;

public class Exp : MonoBehaviour
{
    private float timer;
    private Stats currentStats;

    public float coolDown = 1f;
    public float expGainAmount = 5f;

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
            currentStats.currentExp += expGainAmount;
            timer = coolDown;
        }
        if (currentStats.currentExp == currentStats.expToNextLevel)
        {
            currentStats.currentExp = 0;
        }
    }
}
