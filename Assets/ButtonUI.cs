using UnityEngine;
using UnityEngine.UI;

public class ButtonUI : MonoBehaviour
{
    [Header("MVP References")]
    [SerializeField] HealthPresenter healthPresenter;

    [Header("UI References")]
    [SerializeField] Button DamageButton;
    [SerializeField] Button HealButton;

    string ButtonName = "Button";
    //***************************************************************************
    int damageAmount = 10;
    int healAmount = 10;


    private void Awake()
    {
        DamageButton.onClick.AddListener(() =>
        {
            healthPresenter?.OnDamageButtonClick(damageAmount);
        });

        HealButton.onClick.AddListener(() =>
        {
            healthPresenter?.OnHealButtonClick(healAmount);
        });
    }
}
