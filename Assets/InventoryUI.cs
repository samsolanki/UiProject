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


    private void OnEnable()
    {
        for(int i = 0; i < SlotHeadEquipmentManager.instance.all_HeadInventory.Length; i++)
        {
            if (!SlotHeadEquipmentManager.instance.all_HeadInventory[i].isLocked)
            {
                listOfInventoryItems.Add(SlotHeadEquipmentManager.instance.all_HeadInventory[i]);
            }
        }

        for (int i =0; i< listOfInventoryItems.Count; i++)
        {
            GameObject obj = Instantiate(pf_InventoryButton, transform.position, Quaternion.identity, content);
            obj.transform.GetChild(0).GetComponent<Image>().sprite = listOfInventoryItems[i].sprite;
            obj.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = listOfInventoryItems[i].currentLevel.ToString();
            //obj.transform.parent = content;

            //int index = i;
            obj.GetComponent<Button>().onClick.AddListener(() => OnClick_Object(i));
        }

    }

    public void OnClick_Object(int index)
    {
            Sprite sprite = listOfInventoryItems[index].sprite;
            int currentLevel = listOfInventoryItems[index].currentLevel;
            string name = listOfInventoryItems[index].name;
            //int maxLevel = listOfInventoryItems[index].maxLevel;
            float increaseHealth = listOfInventoryItems[index].healthIncrease;
            //int increaseDamage = listOfInventoryItems[index].damageIncrease;

            this.gameObject.SetActive(false);
            inventoryDetailsUI.gameObject.SetActive(true);
            inventoryDetailsUI.SetAllInventoryDetailsData(name, currentLevel, sprite, increaseHealth);
    }

    public void OnClick_CloseButton()
    {
        this.gameObject.SetActive(false);
    }
}
