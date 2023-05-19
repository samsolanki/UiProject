using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum ExpeditionState
{
    start,
    running,
    claim
}


public class HomeUI : MonoBehaviour
{
    [Header("Settings")]

    [Header("Daily Mission")]

    [Header("Daily Login")]

    [Header("Expedition One")]

    [Header("Expedition Two")]


    [SerializeField] private ExpeditionRunningUI expenditionRunningUI;

    public ExpaditionPanelUI go_ExpaditionPanel;
    [SerializeField] private GameObject go_SettingPenal;
    public GameObject go_DailyRewardPanel;
    [SerializeField] private GameObject go_DailyMissionPanel;

    [SerializeField] private TextMeshProUGUI txt_ExpeditionRunning;


    public ExpeditionState expeditionState;

    [Header("Expedition Buttons")]
    [SerializeField] private Button btn_ExpeditionStart;
    [SerializeField] private Button btn_ExpeditionRunning;
    [SerializeField] private Button btn_ExpeditioClaim;
    private string str_ExpeditionTimeLeft;
  


    private void OnEnable()
    {
        CheckExpeditionState();
    }

    public void ExpeditionOneTimer(float _timeLeft)
    {
        float hours = _timeLeft / 3600;
        float minutes = (_timeLeft % 3600) / 60;
        float seconds = _timeLeft % 60;

        // timer code
        if (_timeLeft < 60)
        {
            str_ExpeditionTimeLeft = seconds.ToString("F0") + "S";
           // txt_ExpeditionRunning.text = str_ExpeditionTimeLeft;
        }
        else if (_timeLeft < 3600)
        {
            str_ExpeditionTimeLeft = minutes.ToString("F0") + "M :" + seconds.ToString("F0") + "S";
            //txt_ExpeditionRunning.text = str_ExpeditionTimeLeft;
        }
        else if (_timeLeft > 3600)
        {
            str_ExpeditionTimeLeft = minutes.ToString("F0") + "M :" + seconds.ToString("F0") + "S";
            //txt_ExpeditionRunning.text = str_ExpeditionTimeLeft;
        }

        txt_ExpeditionRunning.text = str_ExpeditionTimeLeft;

        // expeditionRunningUI.ExpeditionOneTimer();
        expenditionRunningUI.ExpeditionOneTimer(str_ExpeditionTimeLeft, _timeLeft);
    }

    public bool IsExpeditionOneCompeletd
    {
        set
        {
            IsExpeditionOneCompeletd = value;
        }
    }

    public void CompleteExpadition()
    {
        expeditionState = ExpeditionState.claim;
        CheckExpeditionState();
        go_ExpaditionPanel.gameObject.SetActive(false);
        DataManager.instance.all_ExpeditionRunningStatus[0] = false;
        go_ExpaditionPanel.whenCompleteAndTouch1 = true;
    }

    public void CheckExpeditionState()
    {
        if (expeditionState == ExpeditionState.start)
        {
            btn_ExpeditionStart.gameObject.SetActive(true);
            btn_ExpeditionRunning.gameObject.SetActive(false);
            btn_ExpeditioClaim.gameObject.SetActive(false);
        }
        if (expeditionState == ExpeditionState.running)
        {
            btn_ExpeditionStart.gameObject.SetActive(false);
            btn_ExpeditionRunning.gameObject.SetActive(true);
            btn_ExpeditioClaim.gameObject.SetActive(false);
        }

        if (expeditionState == ExpeditionState.claim)
        {
            btn_ExpeditionStart.gameObject.SetActive(false);
            btn_ExpeditionRunning.gameObject.SetActive(false);
            btn_ExpeditioClaim.gameObject.SetActive(true);
        }
    }


    public void OnClick_ExpaditionPanelButtonOpen()
    {
        TimeCalculation.instance.currentExpeditionOneTimer = TimeCalculation.instance.expeditionOneTimer;
        go_ExpaditionPanel.gameObject.SetActive(true);
    }

    public void OnClick_ExpeditionOneRunningScreenOpen()
    {
        go_ExpaditionPanel.gameObject.SetActive(true);
    }


    public void OnClick_ExpeditionClaimButton()
    {
        expeditionState = ExpeditionState.start;
        CheckExpeditionState();
        TimeCalculation.instance.ResetExpeditionOneTimer();
    }

    public void OnClick_StartGame()
    {
        print("Game Start");
    }


    public void OnClick_SettingPanelOpen()
    {
        go_SettingPenal.SetActive(true);
    }

    public void OnClick_DailyRewardPanelOpen()
    {
        go_DailyRewardPanel.SetActive(true);
    }


    public void OnClick_DailyMissionPanelOpen()
    {
        go_DailyMissionPanel.SetActive(true);
    }

}
