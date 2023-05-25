using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EquipmentsSlotUI : MonoBehaviour
{

    [Header("Head Slot")]
    [SerializeField] private Image headSlot;
    [SerializeField] private Image img_PlusIconSprite;
    [SerializeField] private Image img_Empty;
    [SerializeField] private Image img_UpgradeEquipmentIcon;
    [SerializeField] private TextMeshProUGUI txt_CurrentLevel;
    [SerializeField] private GameObject headEquipmentScrollView;

    [Header("Gun Slot")]
    [SerializeField] private Image img_PlusIconSpriteGun;
    [SerializeField] private Image img_EmptyGun;
    [SerializeField] private Image img_UpgradeEquipmentIconGun;
    [SerializeField] private TextMeshProUGUI txt_GunCurrentLevel;
    [SerializeField] private GameObject gunEquipmentScrollView;


    [Header("Arrmor Slot")]
    [SerializeField] private Image img_PlusIconSpriteArrmor;
    [SerializeField] private Image img_EmptyArrmor;
    [SerializeField] private Image img_UpgradeEquipmentIconArrmor;
    [SerializeField] private TextMeshProUGUI txt_ArrmorCurrentLevel;
    [SerializeField] private GameObject arrmorEquipmentScrollView;


    [Header("Glove Slot")]
    [SerializeField] private Image img_PlusIconSpriteGlove;
    [SerializeField] private Image img_EmptyGlove;
    [SerializeField] private Image img_UpgradeEquipmentIconGlove;
    [SerializeField] private TextMeshProUGUI txt_GloveCurrentLevel;
    [SerializeField] private GameObject gloveEquipmentScrollView;


    [Header("Ablities Slot")]
    [SerializeField] private Image img_PlusIconSpriteAblities;
    [SerializeField] private Image img_EmptyAblities;
    [SerializeField] private Image img_UpgradeEquipmentIconAblities;
    [SerializeField] private TextMeshProUGUI txt_AblitiesCurrentLevel;
    [SerializeField] private GameObject ablitiesEquipmentScrollView;


    private void OnEnable()
    {
        if (PlayerSlotManager.instance.isHeadItemEquipped)
        {
            Assign_HeadEquippedItem(); // AssignEquippedItem();
        }
        else
        {
            CheckIfWeHaveAnyHeadItemAvailable(); // CheckIfWeHaveAnyHeadItemAvailable
        }
    }


    #region All Head Items


    public void Assign_HeadEquippedItem()
    {
        img_PlusIconSprite.sprite = SlotHeadEquipmentManager.instance.all_HeadInventory[SlotHeadEquipmentManager.instance.currentEquippmentSelectedIndex].sprite;
        txt_CurrentLevel.text = SlotHeadEquipmentManager.instance.all_HeadInventory[SlotHeadEquipmentManager.instance.currentEquippmentSelectedIndex]
            .currentLevel.ToString();
        txt_CurrentLevel.gameObject.SetActive(true);

        // Check For Updgrade
        CheckIfUpgradeAvailableForEquippedHeadItem();
    }





    public void CheckIfUpgradeAvailableForEquippedHeadItem()
    {
        // IF CURRENT ITEM LEVEL IS GREATER OR EQUAL TO MAX LEVEL


        if (!SlotHeadEquipmentManager.instance.hasEnoughMaterialsForUpgrade(SlotHeadEquipmentManager.instance.currentEquippmentSelectedIndex) ||
            (SlotHeadEquipmentManager.instance.all_HeadInventory[SlotHeadEquipmentManager.instance.currentEquippmentSelectedIndex].currentLevel == SlotHeadEquipmentManager.instance.maxLevel))
        {
            img_UpgradeEquipmentIcon.gameObject.SetActive(false);
        }
        else
        {
            img_UpgradeEquipmentIcon.gameObject.SetActive(true);
        }
    }
    public void CheckIfWeHaveAnyHeadItemAvailable()
    {
        img_PlusIconSprite.gameObject.SetActive(false);
        img_Empty.gameObject.SetActive(true);

        for (int i = 0; i < SlotHeadEquipmentManager.instance.all_HeadInventory.Length; i++)
        {
            if (!SlotHeadEquipmentManager.instance.all_HeadInventory[i].isLocked)
            {
                img_PlusIconSprite.gameObject.SetActive(true);
                img_Empty.gameObject.SetActive(false);
                break;
            }
        }
    }

    public TextMeshProUGUI GetHeadSlotLevelText()
    {
        return txt_CurrentLevel;
    }

    #endregion



    #region All Guns Items

    public void Assign_GunEquippedItem()
    {
        img_PlusIconSpriteGun.sprite = SlotGunsManager.instance.all_GunInventoryItems[SlotGunsManager.instance.currentEquippmentSelectedIndex].sprite;
        txt_GunCurrentLevel.text = SlotGunsManager.instance.all_GunInventoryItems[SlotGunsManager.instance.currentEquippmentSelectedIndex]
            .currentLevel.ToString();
        txt_GunCurrentLevel.gameObject.SetActive(true);

        // Check For Updgrade
        CheckIfUpgradeAvailableForEquippedGunItem();
    }





    public void CheckIfUpgradeAvailableForEquippedGunItem()
    {
        // IF CURRENT ITEM LEVEL IS GREATER OR EQUAL TO MAX LEVEL


        if (!SlotGunsManager.instance.hasEnoughMaterialsForUpgrade(SlotGunsManager.instance.currentEquippmentSelectedIndex) ||
            (SlotGunsManager.instance.all_GunInventoryItems[SlotGunsManager.instance.currentEquippmentSelectedIndex].currentLevel == SlotGunsManager.instance.maxLevel))
        {
            img_UpgradeEquipmentIconGun.gameObject.SetActive(false);
        }
        else
        {
            img_UpgradeEquipmentIconGun.gameObject.SetActive(true);
        }
    }
    public void CheckIfWeHaveAnyGunItemAvailable()
    {
        img_PlusIconSpriteGun.gameObject.SetActive(false);
        img_EmptyGun.gameObject.SetActive(true);

        for (int i = 0; i < SlotGunsManager.instance.all_GunInventoryItems.Length; i++)
        {
            if (!SlotGunsManager.instance.all_GunInventoryItems[i].isLocked)
            {
                img_PlusIconSpriteGun.gameObject.SetActive(true);
                img_EmptyGun.gameObject.SetActive(false);
                break;
            }
        }
    }

    public TextMeshProUGUI GetGunSlotLevelText()
    {
        return txt_GunCurrentLevel;
    }




    #endregion


    #region All Arrmor Items


    public void Assign_ArrmorEquippedItem()
    {
        img_PlusIconSpriteArrmor.sprite = SlotArrmorManager.instance.all_ArrmorInventoryItems[SlotArrmorManager.instance.currentEquippmentSelectedIndex].sprite;
        txt_ArrmorCurrentLevel.text = SlotGunsManager.instance.all_GunInventoryItems[SlotArrmorManager.instance.currentEquippmentSelectedIndex]
            .currentLevel.ToString();
        txt_ArrmorCurrentLevel.gameObject.SetActive(true);

        // Check For Updgrade
        CheckIfUpgradeAvailableForEquippedArrmorItem();
    }





    public void CheckIfUpgradeAvailableForEquippedArrmorItem()
    {
        // IF CURRENT ITEM LEVEL IS GREATER OR EQUAL TO MAX LEVEL


        if (!SlotArrmorManager.instance.hasEnoughMaterialsForUpgrade(SlotArrmorManager.instance.currentEquippmentSelectedIndex) ||
            (SlotArrmorManager.instance.all_ArrmorInventoryItems[SlotArrmorManager.instance.currentEquippmentSelectedIndex].currentLevel == SlotArrmorManager.instance.maxLevel))
        {
            img_UpgradeEquipmentIconArrmor.gameObject.SetActive(false);
        }
        else
        {
            img_UpgradeEquipmentIconArrmor.gameObject.SetActive(true);
        }
    }
    public void CheckIfWeHaveAnyArrmorItemAvailable()
    {
        img_PlusIconSpriteArrmor.gameObject.SetActive(false);
        img_EmptyArrmor.gameObject.SetActive(true);

        for (int i = 0; i < SlotArrmorManager.instance.all_ArrmorInventoryItems.Length; i++)
        {
            if (!SlotArrmorManager.instance.all_ArrmorInventoryItems[i].isLocked)
            {
                img_PlusIconSpriteArrmor.gameObject.SetActive(true);
                img_EmptyArrmor.gameObject.SetActive(false);
                break;
            }
        }
    }

    public TextMeshProUGUI GetArrmorSlotLevelText()
    {
        return txt_ArrmorCurrentLevel;
    }





    #endregion


    public void OnClick_OpenHeadSlot()
    {
        headEquipmentScrollView.SetActive(true);
    }

    public void OnClick_OpenGunsSlot()
    {
        gunEquipmentScrollView.SetActive(true);
    }

    public void OnClick_OpenArrmoSlot()
    {
        arrmorEquipmentScrollView.SetActive(true);
    }

    public void OnClick_OpenGlovesSlot()
    {

    }

    public void OnClick_OpenAbilitesSlot()
    {

    }

    public void OnClick_OpenAnythigSlot()
    {

    }
}
