using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class InventoryDetailsUI : MonoBehaviour
{
    [SerializeField] private EquipmentsSlotUI equipmentSlotUI;
    [SerializeField] private InventoryUI inventoryUI;

    public int index;
    public Image img_EquipmentIcon;
    public TextMeshProUGUI txt_EquipmentName;
    public TextMeshProUGUI txt_EquipmentCurrentLevel;
    public TextMeshProUGUI txt_EquipmentMaxLevel;
    public TextMeshProUGUI txt_EquipmentCurrentValue;
    public TextMeshProUGUI txt_EquipmentIncreaseValue;
    [SerializeField] private Button btn_Update;

    [Header("Materials Property")]
    [SerializeField] private Image img_EquipmentMaterialIcon;
    public TextMeshProUGUI txt_EquipmentcurrentMaterial;
    public TextMeshProUGUI txt_EquipmentRequireMaterial;

    private int currentLevel;

    public void SetAllInventoryDetailsData(int _index, string _name, int _currentLevel, Sprite _icon , float _currentValue , float _increaseValue, int _currentMaterial , int _requireMatrerial)
    {
        index = _index;
        txt_EquipmentName.text = _name;
        img_EquipmentIcon.sprite = _icon;
        currentLevel = _currentLevel;
        txt_EquipmentCurrentLevel.text = _currentLevel.ToString() + " / ";
        txt_EquipmentMaxLevel.text = SlotHeadEquipmentManager.instance.maxLevel.ToString();
        txt_EquipmentCurrentValue.text = _currentValue.ToString();
        txt_EquipmentIncreaseValue.text = $"(+{_increaseValue.ToString()})"  ;
        txt_EquipmentcurrentMaterial.text = _currentMaterial.ToString();
        txt_EquipmentRequireMaterial.text = _requireMatrerial.ToString();
    }


    public Button GetUpdateButton()
    {
        return btn_Update;
    }


    public void OnClick_Equip()
    {
        PlayerSlotManager.instance.isHeadItemEquipped = true;
        print(currentLevel);
        equipmentSlotUI.SetSlotIcon(img_EquipmentIcon.sprite, currentLevel);
        this.gameObject.SetActive(false);
    }


    public void OnClick_EquipmentUpgrade()
    {
        if(equipmentSlotUI.Set_HeadItemUpgradeAvaliableValue(index, currentLevel))
        {
            btn_Update.interactable = true;
            inventoryUI.IncreaseEquipmentLevel(index);
            txt_EquipmentcurrentMaterial.text = SlotHeadEquipmentManager.instance.all_HeadInventory[index].currentMaterials.ToString();
            txt_EquipmentRequireMaterial.text = SlotHeadEquipmentManager.instance.all_HeadInventory[index]
                .requireMaterialToLevelUp[SlotHeadEquipmentManager.instance.all_HeadInventory[index].currentLevel].ToString();

            txt_EquipmentCurrentValue.text = equipmentSlotUI.Set_HeadItemValuesAfterUpgrade(index).ToString();
            txt_EquipmentIncreaseValue.text = $"(+{SlotHeadEquipmentManager.instance.all_HeadInventory[index].healthIncrease[SlotHeadEquipmentManager.instance.all_HeadInventory[index].currentLevel].ToString()})";
        }
        else
        {
            btn_Update.interactable = false;
        }
    }


    public void OnClick_CloseButton()
    {
        this.gameObject.SetActive(false);
    }
}
