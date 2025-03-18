using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TowerDefense;

public class Health : MonoBehaviour
{
    [SerializeField] private int currentHealth;
    [SerializeField] private bool destroyOnZeroHealth;

    public UnityEvent OnTakeDamage = new UnityEvent();
    public UnityEvent OnZeroHealth = new UnityEvent();
    
    void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        ValueDisplay.OnValueChanged.Invoke(gameObject.name + "Health", currentHealth);
        OnTakeDamage.Invoke();

        if(currentHealth <= 0) 
        {
            if(destroyOnZeroHealth) Destroy(gameObject);
            OnZeroHealth.Invoke();
        }
    }

    public static void TryDamage(GameObject target, int damageAmount)
    {
        if (target.TryGetComponent<Health>(out Health health))
        {
            health.TakeDamage(damageAmount);
        }
    }
}
