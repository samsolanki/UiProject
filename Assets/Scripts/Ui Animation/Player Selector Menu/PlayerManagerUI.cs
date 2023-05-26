using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class PlayerManagerUI : MonoBehaviour
{

    // Change the name of the script to : PlayerManagerUI

    [Header("Sub Scripts")]
    public EquipmentsSlotUI ui_EquipmentSlots;
    public HeadInventoryUI ui_InvetoryView;


    [Header("Current Player State")]
    [SerializeField] private TextMeshProUGUI txt_Health;
    [SerializeField] private TextMeshProUGUI txt_Damage;
    [SerializeField] private TextMeshProUGUI txt_Firerate;

    private int characterIndex = 0;
    private int headItemIndex = 0; // increases health
    private int gunItemIndex = 0;
    private int arrmorItemIndex = 0;
    private int gloveItemIndex = 0;
    private int anythigItemIndex = 0;
    private int abilitiesItemIndex = 0;

    /// <summary>
    // TEMPORARAYYY
    [Header("Temporary")]
    public GameObject panel_Upgrade;


   


    private void Start()
    {
        panel_Upgrade.SetActive(true);
        txt_Health.text = HeroesManager.Instance.GetHeroHealth(characterIndex).ToString();
        txt_Damage.text = HeroesManager.Instance.GetHeroDamage(characterIndex).ToString();
        txt_Firerate.text = HeroesManager.Instance.GetHeroFirerate(characterIndex).ToString();
    }


    #region All SlotsSetting Data


    public void SetHeadState()
    {
        if (!PlayerSlotManager.instance.isHeadItemEquipped)
        {
            return;
        }


        // Calculate health only
        // calculate base health
        float baseHealth = HeroesManager.Instance.GetHeroHealth(characterIndex);
        float headSlotHealthBonus = SlotHeadEquipmentManager.instance.all_HeadInventory[SlotHeadEquipmentManager.instance.currentEquippmentSelectedIndex].currentHealth;

        float totalHealth = baseHealth + headSlotHealthBonus;
        txt_Health.text = totalHealth.ToString();

    }

    public void SetGunSlotState()
    {
        if (!PlayerSlotManager.instance.isGunItemEquipped)
        {
            return;
        }

        float baseDamage = HeroesManager.Instance.GetHeroDamage(characterIndex);
        float headSlotDamageBonus = SlotGunsManager.instance.all_GunInventoryItems[SlotGunsManager.instance.currentEquippmentSelectedIndex].currentDamage;

        float totalDamage = baseDamage + headSlotDamageBonus;

        txt_Damage.text = totalDamage.ToString();
    }

    public void SetArrmorSlotState()
    {
        if (!PlayerSlotManager.instance.isArrmorItemEquipped)
        {
            return;
        }

        float baseHealth = HeroesManager.Instance.GetHeroHealth(characterIndex);
        float arrmorSlotHealthBonus = SlotArrmorManager.instance.all_ArrmorInventoryItems[SlotArrmorManager.instance.currentEquippmentSelectedIndex].currentHealth;

        float totalHealth = baseHealth + arrmorSlotHealthBonus;

        txt_Health.text = totalHealth.ToString();
    }

    public void SetGlovesSlotState()
    {

        if (!PlayerSlotManager.instance.isGlovesItemEquipped)
        {
            return;
        }

        float baseDamage = HeroesManager.Instance.GetHeroDamage(characterIndex);
        float headSlotDamageBonus = SlotGlovesManager.instance.all_GlovesInventoryItems[SlotGlovesManager.instance.currentEquippmentSelectedIndex].currentDamage;

        float totalDamage = baseDamage + headSlotDamageBonus;

        txt_Damage.text = totalDamage.ToString();
    }

    public void SetAnythingSlotState()
    {

        if (!PlayerSlotManager.instance.isAnythingItemEquipped)
        {
            return;
        }

        float baseFirerate = HeroesManager.Instance.GetHeroFirerate(characterIndex);
        float anythingSlotFirerateBonus = SlotAnythingManager.instance.all_AnythingInventoryItems[SlotAnythingManager.instance.currentEquippmentSelectedIndex].currentFirerate;

        float totalFirearate = baseFirerate + anythingSlotFirerateBonus;
        txt_Firerate.text = totalFirearate.ToString();
    }

    public void SetAbilitiesSlotState()
    {

        if (!PlayerSlotManager.instance.isAblitiesItemEquipped)
        {
            return;
        }

        float baseFirerate = HeroesManager.Instance.GetHeroFirerate(characterIndex);
        float abilitiesSlotFirerateBonus = SlotAblitiesManager.instance.all_AbilitesInventoryItems[SlotAblitiesManager.instance.currentEquippmentSelectedIndex].currentFirerate;

        float totalFirearate = baseFirerate + abilitiesSlotFirerateBonus;
        txt_Firerate.text = totalFirearate.ToString();
    }


    #endregion

    public void OnClick_OpenHeroSelectionPanel()
    {
        print("Hero Set");
        //playerUpgradePenal.transform.DOScale(new Vector3(1, 1, 1), openMenuAnimationDuration).SetEase(Ease.OutBounce);
        HeroesManager.Instance.ActiveCurrentHero(1);
        //activeHeroStateUI.SetActiveHeroState(1);
    }

    public void OnClick_OpenInventoryPanel()
    {
        //inventoryPenal.transform.DOScale(new Vector3(1, 1, 1), openMenuAnimationDuration).SetEase(Ease.OutBounce);
    }


    public void OnOpenInventoryDetailsPenalButtonCallbak()
    {
        //inventoryObjectDetailsPenal.transform.DOScale(new Vector3(1, 1, 1), .01f).SetEase(Ease.InBounce);
    }


    public void OnClick_PlayerStatePanel()
    {
        //playerStatePenal.transform.DOScale(new Vector3(1, 1, 1), openMenuAnimationDuration).SetEase(Ease.OutBounce);
    }

}
