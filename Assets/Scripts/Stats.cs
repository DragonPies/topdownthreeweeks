using UnityEngine;

public class Stats : MonoBehaviour

{


    [Header("Health & Mana Bars")]

    [Tooltip("This Entity's Max Heath.")][Range (1, 1000)] public float maxHealth;
    [HideInInspector] public float currentHealth;

    [Tooltip("This Entity's Max Mana.")][Range(0,500)] public float maxMana;
    [HideInInspector] public float currentMana;
    [Header("Experience & Leveling")]
    [Tooltip("This Entity's Level.")] public float expToNextLevel;
        [HideInInspector] public float currentExp;



    [Header("Attack")]

    [Tooltip("This Entity's Damage.")] public float damage;
    [Tooltip("This Entity's Defense, Defense is subtracted from incoming damage.")] public float defense;

    [Header("Misc")]

    [Tooltip("how much currency this entity has.")] public int currency;

    [Tooltip("is this entity alive?")] public bool isDead;

    private float timer;
    public float coolDown = 1f;

    private void Start()
    {
        currentHealth = maxHealth;
        currentMana = maxMana;
        isDead = false;
    }

    private void Update()
    {
        
        if (currentHealth <= 0)
        {
            timer -= Time.deltaTime;
            isDead = true;
            if (isDead == true)
            {
                Destroy(gameObject);
                timer = coolDown;
            }
            
            
        }


        if (currentMana > maxMana)
            currentMana = maxMana;

        if (currentHealth > maxHealth)
            currentHealth = maxHealth;
    }
}
