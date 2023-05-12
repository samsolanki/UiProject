using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class PlayerUpdatePanelUI : MonoBehaviour
{

    [Header("All Penal In Scree")]
    [SerializeField] private Image inventoryPenal; //REFERANCE OF INVENOTY PANEL
    [SerializeField] private Image playerStatePenal; // REFERANCE OF ALL PLAYER STATE PANEL
    [SerializeField] private Image playerUpgradePenal; // REFERANCE OF PLAYER UPGRADE PANEL
    [SerializeField] private Image inventoryObjectDetailsPenal; // REFERANCE ALL ALL OBJECTS IN GAME

    [SerializeField] private GameObject[] all_PlayerAbillityButton; // INCREASE PLAYER ABLITY BUTTON


    [SerializeField] private GameObject inventoryobjects; 
    [SerializeField] private List<GameObject> listOfInventoryObjects = new List<GameObject>();


    [SerializeField] private float openMenuAnimationDuration; //TIME FOR OPEN MENU IN THIS MENU
    [SerializeField] private float closeMenuAnimationDuration; //TIME FOR CLOSE MENU IN THIS MENU

    private void Start()
    {
       // playerUpgradePenal.transform.DOScale(new Vector3(0, 0, 0), 0.01f).SetEase(Ease.InBounce);
        //playerStatePenal.transform.DOScale(new Vector3(0, 0, 0), 0.01f).SetEase(Ease.InBounce);
        //inventoryPenal.transform.DOScale(new Vector3(0, 0, 0), .01f).SetEase(Ease.InBounce);
        //inventoryObjectDetailsPenal.transform.DOScale(new Vector3(0, 0, 0), .01f).SetEase(Ease.InBounce);
        
        for (int i = 0; i < inventoryobjects.transform.childCount; i++)
        {
            listOfInventoryObjects.Add(inventoryobjects.transform.GetChild(i).gameObject);
            inventoryobjects.transform.GetChild(i).GetComponent<InventoryDetails>().InventoryIndex = i;
        }
    }


    public void OnClickAbilityButtonCallback(int index)
    {
        
    }


    public void OnPlayerUpgradePenalCallback()
    {
        playerUpgradePenal.transform.DOScale(new Vector3(1, 1, 1), openMenuAnimationDuration).SetEase(Ease.OutBounce);
    }

    public void OnInventoryButtonCallback()
    {
        inventoryPenal.transform.DOScale(new Vector3(1, 1, 1), openMenuAnimationDuration).SetEase(Ease.OutBounce);
    }

    
    public void OnClickInventoryEquireButtonCallback(int index)
    {

    }

    public void OnOpenInventoryDetailsPenalButtonCallbak()
    {
        inventoryObjectDetailsPenal.transform.DOScale(new Vector3(1, 1, 1), .01f).SetEase(Ease.InBounce);
    }

    public void OnHideInventoryDetailsButtonCallback()
    {
        inventoryObjectDetailsPenal.transform.DOScale(new Vector3(0, 0, 0), .01f).SetEase(Ease.InBounce);
    }

    public void OnPlayerStateButtonCallback()
    {
        playerStatePenal.transform.DOScale(new Vector3(1, 1, 1), openMenuAnimationDuration).SetEase(Ease.OutBounce);
    }

    public void OnCloseButtonCallback()
    {
        playerUpgradePenal.transform.DOScale(new Vector3(0, 0, 0), closeMenuAnimationDuration).SetEase(Ease.InBounce);
        playerStatePenal.transform.DOScale(new Vector3(0, 0, 0), closeMenuAnimationDuration).SetEase(Ease.InBounce);
        inventoryPenal.transform.DOScale(new Vector3(0, 0, 0), closeMenuAnimationDuration).SetEase(Ease.InBounce);
    }
}
