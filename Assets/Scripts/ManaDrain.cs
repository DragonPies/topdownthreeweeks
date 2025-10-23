using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ManaDrain : MonoBehaviour
    
{
     private Stats currentStats;

     public float manaDrainAmount = 10f;


     public void Manadrain(InputAction.CallbackContext ctx)
    {
             {
            ctx.ReadValue<float>();
            currentStats.currentMana -= manaDrainAmount;
             }

     }

}
