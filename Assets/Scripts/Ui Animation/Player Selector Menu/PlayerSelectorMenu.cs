using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class PlayerSelectorMenu : MonoBehaviour
{

    [Header("All Penal In Scree")]
    [SerializeField] private Image inventoryPenal;
    [SerializeField] private Image playerStatePenal;
    [SerializeField] private Image playerUpgradePenal;
    [SerializeField] private Image inventoryObjectDetailsPenal;

    [SerializeField] private GameObject[] playerAbillityButton;


    [SerializeField] private GameObject inventoryobjects;
    [SerializeField] private List<GameObject> listOfInventoryObjects = new List<GameObject>();
    private int inventoryActiveIndex;


    [SerializeField] private float startAnimationDuration;
    [SerializeField] private float closeAnimationDuration;

    private void Start()
    {
        playerUpgradePenal.transform.DOScale(new Vector3(0, 0, 0), 0.01f).SetEase(Ease.InBounce);
        playerStatePenal.transform.DOScale(new Vector3(0, 0, 0), 0.01f).SetEase(Ease.InBounce);
        inventoryPenal.transform.DOScale(new Vector3(0, 0, 0), .01f).SetEase(Ease.InBounce);
        inventoryObjectDetailsPenal.transform.DOScale(new Vector3(0, 0, 0), .01f).SetEase(Ease.InBounce);
        for (int i = 0; i < inventoryobjects.transform.childCount; i++)
        {
            listOfInventoryObjects.Add(inventoryobjects.transform.GetChild(i).gameObject);
            inventoryobjects.transform.GetChild(i).GetComponent<InventoryDetails>().InventoryIndex = i;
        }
    }


    private void Update()
    {  

        
    }


    public void OnClickAbilityButtonCallback(int index)
    {
        print("Index of button " + index);
    }


    public void OnPlayerUpgradePenalCallback()
    {
        playerUpgradePenal.transform.DOScale(new Vector3(1, 1, 1), startAnimationDuration).SetEase(Ease.OutBounce);
    }

    public void OnInventoryButtonCallback()
    {
        inventoryPenal.transform.DOScale(new Vector3(1, 1, 1), startAnimationDuration).SetEase(Ease.OutBounce);
    }

    
    public void OnClickInventoryEquireButtonCallback(int index)
    {
        for(int i = 0; i < listOfInventoryObjects.Count; i++)
        {
            index = listOfInventoryObjects[i].GetComponent<InventoryDetails>().InventoryIndex;
        }

        print("Index of selected abbility " + index);
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
        playerStatePenal.transform.DOScale(new Vector3(1, 1, 1), startAnimationDuration).SetEase(Ease.OutBounce);
    }

    public void OnCloseButtonCallback()
    {
        playerUpgradePenal.transform.DOScale(new Vector3(0, 0, 0), closeAnimationDuration).SetEase(Ease.InBounce);
        playerStatePenal.transform.DOScale(new Vector3(0, 0, 0), closeAnimationDuration).SetEase(Ease.InBounce);
        inventoryPenal.transform.DOScale(new Vector3(0, 0, 0), closeAnimationDuration).SetEase(Ease.InBounce);
    }
}
