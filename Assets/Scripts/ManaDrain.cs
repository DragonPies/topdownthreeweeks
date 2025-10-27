using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ManaDrain : MonoBehaviour
    
{
     private Stats currentStats;

     public float manaDrainAmount = 10f;

    private void Update()
    {
        if (TryGetComponent(out Stats stats))
        {
            currentStats = stats;
        }
        if (Input.GetMouseButtonDown(0) && (currentStats.currentMana >= manaDrainAmount))
        {
         
            currentStats.currentMana -= manaDrainAmount;
            Debug.Log("Mana Drained");
        }
    }








}
