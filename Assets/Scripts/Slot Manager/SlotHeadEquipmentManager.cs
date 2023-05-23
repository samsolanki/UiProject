using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotHeadEquipmentManager : MonoBehaviour
{
    public static SlotHeadEquipmentManager instance;

    public HeadInventoryProperty[] all_HeadInventory;

    public int maxLevel;

    private void Awake()
    {
        instance = this;
    }

}
