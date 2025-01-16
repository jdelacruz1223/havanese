using Mono.Cecil.Cil;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] public static int maxHealth = 3;

    private DataManager DM => DataManager.Instance;
    

    private void Awake()
    {
        DM.currentHealth = maxHealth;
    }

    private void Start()
    {
        
    }

    private void DamageHealth(int amount)
    {
        DataManager.Instance.currentHealth -= amount;
    }
}
