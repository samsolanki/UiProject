using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomePenalAnimation : MonoBehaviour
{
    [SerializeField] private GameObject go_trainingPenal;
    [SerializeField] private GameObject go_SettingPenal;
    [SerializeField] private GameObject go_DailyRewardPanel;
    [SerializeField] private GameObject go_DailyMissionPanel;


    private int currentIndex;


    public int GetCurrentIndex
    {
        get
        {
            return currentIndex;
        }
        set
        {
            currentIndex = value;
        }
    }

    public void OnClick_TranningPanelButtonOpen1(int index)
    {
        currentIndex = index;
        go_trainingPenal.SetActive(true);
    }

    public void OnClick_TranningPanelButtonOpen2(int index)
    {
        currentIndex = index;
        go_trainingPenal.SetActive(true);
    }

    public void OnClick_TranningPanelClose()
    {
        go_trainingPenal.SetActive(false);
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
