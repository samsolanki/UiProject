using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ActiveHeroStateUI : MonoBehaviour
{

    [Header("State Data")]
    [SerializeField] private TextMeshProUGUI txt_HealthAmount;
    [SerializeField] private TextMeshProUGUI txt_DamageAmount;
    [SerializeField] private TextMeshProUGUI txt_FirerateAmount;


    private void Start()
    {
        SetActiveHeroState(PlayerPrefs.GetInt(PlayerPrefsKey.PLAYERPREFS_HERO_ACTIVE_INDEX));
        
    }

    public void SetActiveHeroState(int _ActiveHeroIndex)
    {
        txt_HealthAmount.text = HeroesManager.Instance.GetHeroHealth(_ActiveHeroIndex).ToString();
        txt_DamageAmount.text = HeroesManager.Instance.GetHeroDamage(_ActiveHeroIndex).ToString();
        txt_FirerateAmount.text = HeroesManager.Instance.GetHeroFirerate(_ActiveHeroIndex).ToString();
    }
}
