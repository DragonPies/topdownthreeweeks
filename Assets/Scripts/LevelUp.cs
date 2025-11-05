using TMPro;
using UnityEngine;

public class LevelUp : MonoBehaviour
{
    public float timeValue = 60f;
    public Stats stats;

    [Header("Stats Increase Per Level")]
    public float healthIncrease = 1.5f;
    public float damageIncrease = 1.2f;
    public float defenseIncrease = 1.2f;


    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }

        else
        {
            timeValue = 60f;
            stats.maxHealth *= healthIncrease;
            stats.damage *= damageIncrease;
            stats.defense *= defenseIncrease;
        }
     
    }


    
}
