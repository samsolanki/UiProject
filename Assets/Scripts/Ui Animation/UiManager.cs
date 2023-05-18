using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;


    public HomeUI homeUi;
    public SettingUI settingUI;
    public RewardSummaryUI rewardSummaryUI;


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
