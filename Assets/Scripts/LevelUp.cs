using TMPro;
using UnityEngine;

public class LevelUp : MonoBehaviour
{
    public float timeValue = 60f;
    public TextMeshProUGUI timeText;
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
        DisplayTime(timeValue);
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay += 60f;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}
