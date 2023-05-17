using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomePenalAnimation : MonoBehaviour
{
    [SerializeField] private GameObject go_ExpaditionPanel;
    [SerializeField] private GameObject go_ExpaditionPanelWithAds;
    [SerializeField] private GameObject go_SettingPenal;
    [SerializeField] private GameObject go_DailyRewardPanel;
    [SerializeField] private GameObject go_DailyMissionPanel;


  
    public void OnClick_ExpaditionPanelButtonOpen()
    {
        go_ExpaditionPanel.SetActive(true);
    }
    public void OnClick_ExpaditionPanelClose()
    {
        go_ExpaditionPanel.SetActive(false);
    }

    public void OnClick_ExpaditionPanelWithAdsButtonOpen()
    {
        go_ExpaditionPanelWithAds.SetActive(true);
    }
    public void OnClick_ExpaditionPanelWithAdsButtonClose()
    {
        go_ExpaditionPanelWithAds.SetActive(false);
    }


    public void OnClick_StartGame()
    {
        print("Game Start");
    }


    public void OnClick_SettingPanelOpen()
    {
        go_SettingPenal.SetActive(true);
    }
    public void OnClick_SettingPanelClose()
    {
        go_SettingPenal.SetActive(false);
    }

    public void OnClick_DailyRewardPanelOpen()
    {
        go_DailyRewardPanel.SetActive(true);
    }

    public void OnClick_DailyRewardPanelClose()
    {
        go_DailyRewardPanel.SetActive(false);
    }

    public void OnClick_DailyMissionPanelOpen()
    {
        go_DailyMissionPanel.SetActive(true);
    }

    public void OnClick_DailyMissionPanelClose()
    {
        go_DailyMissionPanel.SetActive(false);
    }
}
