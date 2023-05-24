using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] private InventoryDetailsUI inventoryDetailsUI;

    public List<HeadInventoryProperty> listOfInventoryItems = new List<HeadInventoryProperty>();
    [SerializeField] private GameObject pf_InventoryButton;   
    [SerializeField] private Transform content;
    GameObject obj;

    private void OnEnable()
    {

        for (int i = 0; i < SlotHeadEquipmentManager.instance.all_HeadInventory.Length; i++)
        {
            if (!SlotHeadEquipmentManager.instance.all_HeadInventory[i].isLocked)
            {
                listOfInventoryItems.Add(SlotHeadEquipmentManager.instance.all_HeadInventory[i]);
            }
        }

        for (int i =0; i< listOfInventoryItems.Count; i++)
        {
            print("OIbvjects is added");
            obj = Instantiate(pf_InventoryButton, transform.position, Quaternion.identity, content);
            obj.GetComponent<HeadEquipmentPrefabData>().img_EquipmentIcon.sprite = listOfInventoryItems[i].sprite;
            obj.GetComponent<HeadEquipmentPrefabData>().txt_EquipmentCurrentLevel.text = listOfInventoryItems[i].currentLevel.ToString();
            int index = i;
            obj.GetComponent<Button>().onClick.AddListener(() => OnClick_Object(index));
        }
    }

    public void OnClick_Object(int index)
    {
        Sprite sprite = listOfInventoryItems[index].sprite;
        int currentLevel = listOfInventoryItems[index].currentLevel;
        string name = listOfInventoryItems[index].name;
        float currentHealth = listOfInventoryItems[index].currentHealth;
        float increaseHealth = listOfInventoryItems[index].healthIncrease[currentLevel];

        int currentMaterial = listOfInventoryItems[index].currentMaterials;
        int requireMaterial = listOfInventoryItems[index].requireMaterialToLevelUp[currentLevel];

        this.gameObject.SetActive(false);
        inventoryDetailsUI.gameObject.SetActive(true);
        inventoryDetailsUI.SetAllInventoryDetailsData(index ,name, currentLevel, sprite, currentHealth, increaseHealth , currentMaterial , requireMaterial);

        CheckIfLevelReachMax(index);

    }


    public void IncreaseEquipmentLevel(int index)
    {
        print("Methiod called");
        listOfInventoryItems[index].currentLevel++;
        inventoryDetailsUI.txt_EquipmentCurrentLevel.text = listOfInventoryItems[index].currentLevel.ToString();
        CheckIfLevelReachMax(index);
    }

    public void CheckIfLevelReachMax(int _index)
    {
        if(listOfInventoryItems[_index].currentLevel >= SlotHeadEquipmentManager.instance.maxLevel)
        {
            inventoryDetailsUI.GetUpdateButton().gameObject.SetActive(false);
            inventoryDetailsUI.txt_EquipmentCurrentLevel.text = "Max Level";
            inventoryDetailsUI.txt_EquipmentMaxLevel.gameObject.SetActive(false);
        }
    }



    public void OnClick_CloseButton()
    {
        this.gameObject.SetActive(false);
    }
}
