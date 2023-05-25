using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;


    public HomeUI homeUi; // ui_Home
    public SettingUI settingUI; // ui_Settings
    public RewardSummaryUI rewardSummaryUI; // ui_RewardSummary
    public PlayerManagerUI ui_PlayerSelect; 


    [SerializeField] private bool canChangeMenus;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }


    public bool CanChangeMenus
    {
        get
        {
            return canChangeMenus;
        }
        set
        {
            canChangeMenus = value;
        }
    }

}
