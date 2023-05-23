using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class PlayerSelectUI : MonoBehaviour
{

    [Header("All Penal In Scree")]

    [SerializeField] private ActiveHeroStateUI activeHeroStateUI;


    [SerializeField] private Image inventoryPenal; //REFERANCE OF INVENOTY PANEL
    [SerializeField] private Image playerStatePenal; // REFERANCE OF ALL PLAYER STATE PANEL
    [SerializeField] private Image playerUpgradePenal; // REFERANCE OF PLAYER UPGRADE PANEL
    [SerializeField] private Image inventoryObjectDetailsPenal; // REFERANCE ALL ALL OBJECTS IN GAME

    [SerializeField] private GameObject[] all_PlayerAbillityButton; // INCREASE PLAYER ABLITY BUTTON


    [SerializeField] private GameObject inventoryobjects; 


    [SerializeField] private float openMenuAnimationDuration; //TIME FOR OPEN MENU IN THIS MENU
    [SerializeField] private float closeMenuAnimationDuration; //TIME FOR CLOSE MENU IN THIS MENU


    /// <summary>
    // TEMPORARAYYY
    public GameObject panel_Upgrade;
    private void Start()
    {
        panel_Upgrade.SetActive(true);
    }


    /// </summary>


    public void OnClick_OpenHeroSelectionPanel()
    {
        print("Hero Set");
        //playerUpgradePenal.transform.DOScale(new Vector3(1, 1, 1), openMenuAnimationDuration).SetEase(Ease.OutBounce);
        PlayerPrefs.SetInt(PlayerPrefsKey.PLAYERPREFS_HERO_ACTIVE_INDEX, 1);
        HeroesManager.Instance.ActiveCurrentHero(PlayerPrefs.GetInt(PlayerPrefsKey.PLAYERPREFS_HERO_ACTIVE_INDEX));
        activeHeroStateUI.SetActiveHeroState(PlayerPrefs.GetInt(PlayerPrefsKey.PLAYERPREFS_HERO_ACTIVE_INDEX));
    }

    public void OnClick_OpenInventoryPanel()
    {
        inventoryPenal.transform.DOScale(new Vector3(1, 1, 1), openMenuAnimationDuration).SetEase(Ease.OutBounce);
    }


    public void OnOpenInventoryDetailsPenalButtonCallbak()
    {
        inventoryObjectDetailsPenal.transform.DOScale(new Vector3(1, 1, 1), .01f).SetEase(Ease.InBounce);
    }


    public void OnClick_PlayerStatePanel()
    {
        playerStatePenal.transform.DOScale(new Vector3(1, 1, 1), openMenuAnimationDuration).SetEase(Ease.OutBounce);
    }

}
