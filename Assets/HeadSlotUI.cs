using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeadSlotUI : MonoBehaviour
{

    [SerializeField] private Image img_Button;


    [SerializeField] private Sprite sprite_Empty;
    [SerializeField] private Sprite sprite_Plus;

    private void Start()
    {
        CheckIfAnyUpgradeToApply();
    }

    private void CheckIfAnyUpgradeToApply()
    {
        //if (SlotHeadEquipmentManager.instance.isSlotIsActive == true)
        //{
        //    img_Button.sprite = sprite_Plus;
        //}
        //else
        //{
        //    img_Button.sprite = sprite_Empty;
        //}
    }
}
