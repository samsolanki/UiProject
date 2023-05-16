using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;


    public RewardSummaryPanel rewardSummaryPanel;


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
