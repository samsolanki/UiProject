using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ExpeditionRunningUI : MonoBehaviour
{

    [SerializeField] private int expeditionIndex;

    [SerializeField] private ExpaditionReward rewardData;
    [SerializeField] private GameObject go_ExpaditionScreen;

    public TextMeshProUGUI txt_expanditionTimer;
    public Slider slider_ExpanditionSlider;

    [SerializeField] private Image icon_Expedition;

    [Header("Reward 1 Data")]
    [SerializeField] private TextMeshProUGUI rewardAmount1;

    [Header("Reward 2 Data")]
    [SerializeField] private TextMeshProUGUI rewardAmount2;


    private void Start()
    {
        SetSliderMaxValue();
    }


    private void SetSliderMaxValue()
    {
        slider_ExpanditionSlider.maxValue = TimeCalculation.instance.expeditionOneTimer;
    }


    //public void SetExpaditionProcessingData(Sprite _reward1Sprite , string _reward1Amount , Sprite _reward2Sprite , string _reward2Amount)
    //{
    //    rewardIcon1.sprite = _reward1Sprite;
    //    rewardAmount1.text = _reward1Amount;

    //    rewardIcon2.sprite = _reward2Sprite;
    //    rewardAmount2.text = _reward2Amount;
    //}

    public void SetExpeditionRunningData()
    {
        icon_Expedition.sprite = rewardData.all_IconSprites[DataManager.instance.expeditionOneIndex];
        rewardAmount1.text = rewardData.allFirstRewardAmounts[DataManager.instance.expeditionOneIndex].ToString();
        rewardAmount2.text = rewardData.allSecondRewardAmounts[DataManager.instance.expeditionOneIndex].ToString();

        //rewardIcon2.sprite = rewardData.all_IconSprites[DataManager.instance.expeditionOneIndex];
    }


    public void ExpeditionOneTimer(string _timeLeftInString, float _timeLeft)
    {
        slider_ExpanditionSlider.value = _timeLeft;

        txt_expanditionTimer.text = _timeLeftInString;

        //float hours = _timeLeft / 3600;
        //float minutes = (_timeLeft % 3600) / 60;
        //float seconds = _timeLeft % 60;


        //if (_timeLeft < 60)
        //{
        //    txt_expanditionTimer.text = seconds.ToString("F0") + "S";
        //}
        //else if (_timeLeft < 3600)
        //{
        //    txt_expanditionTimer.text = minutes.ToString("F0") + "M :" + seconds.ToString("F0") + "S ";
        //}
        //else if (_timeLeft > 3600)
        //{
        //    txt_expanditionTimer.text = hours.ToString("F0") + "H :" + minutes.ToString("F0") + "M :" + seconds.ToString("F0") + "S ";
        //}
    }


    public void OnClick_FinishExpadition()
    {
        UiManager.instance.homeUi.CompleteExpadition();
        this.gameObject.SetActive(false);
        go_ExpaditionScreen.SetActive(true);
        DataManager.instance.all_ExpeditionRunningStatus[0] = false;
        TimeCalculation.instance.ResetExpeditionOneTimer();
    }

}
