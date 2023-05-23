using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class InventoryDetailsUI : MonoBehaviour
{
    [SerializeField] private EquipmentsSlotUI upgradeSlotUI;

    public Image upgradeIcon;
    public TextMeshProUGUI upgradeName;
    [SerializeField] private TextMeshProUGUI txt_currentLevel;
    public TextMeshProUGUI upgradeMaxLevel;
    public TextMeshProUGUI currentHealth;
    public TextMeshProUGUI upgradeHeadth;
    public TextMeshProUGUI currentDamage;
    public TextMeshProUGUI upgradeDamage;

    [Header("Materials Property")]
    [SerializeField] private Image img_MaterialIcon;
    [SerializeField] private TextMeshProUGUI txt_currentMaterial;
    [SerializeField] private TextMeshProUGUI txt_RequireMaterial;

    private int currentLevel;

    public void SetAllInventoryDetailsData(string name, int _currentLevel , Sprite icon , float _value)
    {
        upgradeName.text = name;
        upgradeIcon.sprite = icon;
        currentLevel = _currentLevel;
        txt_currentLevel.text = _currentLevel.ToString();
        //upgradeMaxLevel.text = maxLevel.ToString();
        upgradeHeadth.text = $"(+{_value.ToString()})"  ;
        //upgradeDamage.text = $"(+{increaseDamage.ToString()})" ;
        currentHealth.text = HeroesManager.Instance.GetHeroHealth(PlayerPrefs.GetInt(PlayerPrefsKey.PLAYERPREFS_HERO_ACTIVE_INDEX)).ToString();
        currentDamage.text = HeroesManager.Instance.GetHeroDamage(PlayerPrefs.GetInt(PlayerPrefsKey.PLAYERPREFS_HERO_ACTIVE_INDEX)).ToString();
    }

    public void OnClick_Equip()
    {
        print(currentLevel);
        upgradeSlotUI.SetSlotIcon(upgradeIcon.sprite, currentLevel);
        this.gameObject.SetActive(false);
    }

    public void OnClick_CloseButton()
    {
        this.gameObject.SetActive(false);
    }
}
