using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public event Action OnHealthChanged;

    const int minHealth = 0;
    const int maxHealth = 100;
    int currentHealth;

    public int CurrentHealth { get => currentHealth; set => currentHealth = value; }
    public int MinHealth => minHealth;
    public int MaxHealth => maxHealth;

    public void HealthArttirma (int arttirmaAmount)
    {
        currentHealth += arttirmaAmount;
        currentHealth = Mathf.Max(currentHealth, minHealth);

        OnHealthChanged?.Invoke();
    }

    public void HealthAzaltma(int azaltmaAmount)
    {
        currentHealth -= azaltmaAmount;
        currentHealth = Mathf.Min(currentHealth, maxHealth);

        OnHealthChanged?.Invoke();
    }
}
