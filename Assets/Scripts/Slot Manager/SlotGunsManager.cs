using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotGunsManager : MonoBehaviour
{
    public static SlotGunsManager instance;


    public GunEquipmentProperty[] all_GunInventoryItems;
    public int currentMaterialCount;
    public int currentEquippmentSelectedIndex;

    public int maxLevel;
    private void Awake()
    {
        instance = this;
    }

    public bool hasEnoughMaterialsForUpgrade(int _slotIndex)
    {
        if (currentMaterialCount >= all_GunInventoryItems[_slotIndex].requireMaterialToLevelUp[all_GunInventoryItems[_slotIndex].currentLevel])
        {
            return true;
        }

        return false;
    }

    public bool hasEnoughCoinsForUpgrade(int _slotIndex)
    {
        //if (currentMaterialCount >= all_HeadInventory[_slotIndex].c[all_HeadInventory[_slotIndex].currentLevel])
        //{
        //    return true;
        //}

        if (DataManager.instance.coins >= all_GunInventoryItems[_slotIndex].requireCoinsToUpgrade)
        {
            return true;
        }

        return false;
    }


    public void SetLevelData()
    {
        if (all_GunInventoryItems[currentEquippmentSelectedIndex].currentLevel > 1)
        {
            for (int i = 0; i < all_GunInventoryItems[currentEquippmentSelectedIndex].currentLevel; i++)
            {
                all_GunInventoryItems[currentEquippmentSelectedIndex].currentDamage += all_GunInventoryItems[currentEquippmentSelectedIndex].damageIncrease;
            }
        }
    }


    public void UpgradeEquipnent(int _itemIndex)
    {
        currentMaterialCount -= all_GunInventoryItems[_itemIndex].requireMaterialToLevelUp[all_GunInventoryItems[_itemIndex].currentLevel];
        DataManager.instance.coins -= all_GunInventoryItems[_itemIndex].requireCoinsToUpgrade;
        all_GunInventoryItems[_itemIndex].currentDamage += all_GunInventoryItems[_itemIndex].damageIncrease;
        all_GunInventoryItems[_itemIndex].currentLevel++;
    }
}
