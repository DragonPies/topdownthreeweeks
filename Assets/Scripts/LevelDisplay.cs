using TMPro;
using UnityEngine;

public class LevelDisplay : MonoBehaviour
{
    private float timer;
    private Stats currentStats;
    private int level;

    public float coolDown = 60f;
    public TextMeshProUGUI levelText;


    private void Start()
    {
        level = 0;
        levelText.text = "Level: " + level.ToString();
    }

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
            
            timer = coolDown;
            levelText.text = "Level: " + (++level).ToString();
        }
    }
}
