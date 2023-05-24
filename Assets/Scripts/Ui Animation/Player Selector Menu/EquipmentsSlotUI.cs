using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EquipmentsSlotUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI currentLevel;

    [Header("Head Slot")]
    [SerializeField] private Image headSlot;
    [SerializeField] private Image img_PlusIconSprite;
    [SerializeField] private Image img_Empty;
    [SerializeField] private Image img_UpgradeEquipmentIcon;
    [SerializeField] private GameObject headEquipmentScrollView;
    public bool isEquippedItemUpgradeAvaliable;


    private void OnEnable()
    {
        if (PlayerSlotManager.instance.isHeadItemEquipped)
        {
            CheckIfHeadItemEquipped();
            CheckIf_HeadItemUpgradeAvaliable();
        }
        else
        {
            CheckIfAny_HeadItemIsUnlocked();
        }
    }


    public void CheckIfHeadItemEquipped()
    {
        print("Item is Equipped");
    }

    public void CheckIf_HeadItemUpgradeAvaliable()
    {
        if (isEquippedItemUpgradeAvaliable)
        {
            img_UpgradeEquipmentIcon.gameObject.SetActive(true);
        }
        else
        {
            img_UpgradeEquipmentIcon.gameObject.SetActive(false);
        }
    }

    public void CheckIfAny_HeadItemIsUnlocked()
    {
        for (int i = 0; i < SlotHeadEquipmentManager.instance.all_HeadInventory.Length; i++)
        {
            if (!SlotHeadEquipmentManager.instance.all_HeadInventory[i].isLocked)
            {
                img_PlusIconSprite.gameObject.SetActive(true);
                img_Empty.gameObject.SetActive(false);
                break;
            }
            else
            {
                img_PlusIconSprite.gameObject.SetActive(false);
                img_Empty.gameObject.SetActive(true);
            }
        }
    }


    public bool Set_HeadItemUpgradeAvaliableValue(int index , int currentIndex)
    {
        if(SlotHeadEquipmentManager.instance.all_HeadInventory[index].currentMaterials > SlotHeadEquipmentManager.instance.all_HeadInventory[index].requireMaterialToLevelUp[currentIndex])
        {
            SlotHeadEquipmentManager.instance.all_HeadInventory[index].currentMaterials -= SlotHeadEquipmentManager.instance.all_HeadInventory[index].requireMaterialToLevelUp[currentIndex];
            return true;
        }
        return false;
    }

    public float Set_HeadItemValuesAfterUpgrade(int index)
    {
        float currentHealth = SlotHeadEquipmentManager.instance.all_HeadInventory[index].currentHealth;
        float updatedHealth = SlotHeadEquipmentManager.instance.all_HeadInventory[index].healthIncrease[SlotHeadEquipmentManager.instance.all_HeadInventory[index].currentLevel];

        float changeHealth = currentHealth + updatedHealth;

        SlotHeadEquipmentManager.instance.all_HeadInventory[index].currentHealth = changeHealth;

        currentHealth = changeHealth;


        print("current Health " + currentHealth + " Update Health " + updatedHealth);

        return currentHealth;

    }


    public void SetSlotIcon(Sprite image , int _currentLevel)
    {
        headSlot.sprite = image;
        currentLevel.text = _currentLevel.ToString();
        currentLevel.gameObject.SetActive(true);
    }

    public void OnClick_OpenHeadSlot()
    {
        headEquipmentScrollView.SetActive(true);
    }

    public void OnClick_OpenGunsSlot()
    {
       
    }

    public void OnClick_OpenArrmoSlot()
    {

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
