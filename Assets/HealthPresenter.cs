using DG.Tweening;
using System;
using UnityEngine;
using UnityEngine.UI;

public class HealthPresenter : MonoBehaviour
{
    [Header("Model")]
    [SerializeField] Health health;

    [Header("View")]
    [SerializeField] Slider healthSlider;

    private void Start()
    {
        health.OnHealthChanged += Health_OnHealthChanged;

        health.CurrentHealth = health.MaxHealth;
    }

    private void Health_OnHealthChanged()
    {
        if (health == null) { return; }

        if (healthSlider != null && health.MaxHealth != 0)
        {
            float targetValue = (float)health.CurrentHealth / (float)health.MaxHealth;
            float animationDuration = 0.5f;

            healthSlider.DOValue(targetValue, animationDuration);
        }
    }

    public void OnDamageButtonClick(int amount)
    {
        health?.HealthAzaltma(amount);
    }

    public void OnHealButtonClick(int amount)
    {
        health?.HealthArttirma(amount);
    }

    private void OnDestroy()
    {
        health.OnHealthChanged -= Health_OnHealthChanged;
    }
}
