using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EquipmentsSlotUI : MonoBehaviour
{
    [SerializeField] private Image headSlot;
    [SerializeField] private TextMeshProUGUI currentLevel;
    [SerializeField] private GameObject headEquipmentScrollView;

    [Header("Head Slot")]
    [SerializeField] private Image img_Button;
      

    private void OnEnable()
    {
        // check if any head item available.

        // HEAD
        // if(playerslotmanager.isHeadItemEquipped){

        // show head icon which is equipped. 

            // if( isEquippedItemUpgradeAvailable){

                // shot ! symbol
            // }
        //}
        // else{

               // for loop to check if any unlocked item is there.
        // }
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
