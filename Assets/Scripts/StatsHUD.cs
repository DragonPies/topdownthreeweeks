using UnityEngine;
using UnityEngine.UI;

public class StatsHUD : MonoBehaviour
{
    public Stats stats;

    public Image healthBar;
    public Image manaBar;
    public Image expBar;


    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = stats.currentHealth / stats.maxHealth;
        manaBar.fillAmount = stats.currentMana / stats.maxMana;
        expBar.fillAmount = stats.currentExp / stats.expToNextLevel;
    }
}
