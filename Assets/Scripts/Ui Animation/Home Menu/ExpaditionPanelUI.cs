using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ExpaditionPanelUI : MonoBehaviour
{

    [SerializeField] private int myPanelId;

    [SerializeField] private ExpaditionReward rewardData;

    [SerializeField] private GameObject go_ExpaditionScreen;
    [SerializeField] private ExpeditionRunningUI expeditionRunningUI;


    [Header("Reward Data of Expedition Screen")]

    public ExpaditionRewardData[] all_ExpeditionRewardOneData;
    public ExpaditionRewardData[] all_ExpeditionRewardTwoData;


    private int levelMultiplier = 100;

    public bool whenCompleteAndTouch1;
    public bool whenCompleteAndTouch2;



    private void OnEnable()
    {

        //sChechWhichExpeditionStateInRunning();

        //SET ALL DATA IN THE EXPEDITION ONE SCREEN

        SetExpeditionData();
    }



    //private void ChechWhichExpeditionStateInRunning()
    //{
    //    // check which screen to activate
    //    if (UiManager.instance.homeUi.expeditionState == ExpeditionState.running)
    //    {
    //        go_ExpaditionTimerScreen.gameObject.SetActive(true);
    //        go_ExpaditionScreen.SetActive(false);
    //    }
    //    else
    //    {
    //        go_ExpaditionTimerScreen.gameObject.SetActive(false);
    //        go_ExpaditionScreen.SetActive(true);
    //    }
    //}


    private void SetExpeditionData()
    {
        //int rewardToAddInEachSlot = DataManager.instance.playerLevel * levelMultiplier;
        for (int i = 0; i < all_ExpeditionRewardOneData.Length; i++)
        {
            TextMeshProUGUI rewardText1 = all_ExpeditionRewardOneData[i].rewardText1;
            TextMeshProUGUI rewardText2 = all_ExpeditionRewardOneData[i].rewardText2;

            rewardText1.text = (rewardData.allFirstRewardAmounts[i]).ToString();
            rewardText2.text = (rewardData.allSecondRewardAmounts[i]).ToString();
        }

        //SET ALL DATA IN THE EXPEDITION TWO SCREEN

        for (int i = 0; i < all_ExpeditionRewardTwoData.Length; i++)
        {
            TextMeshProUGUI rewardText1 = all_ExpeditionRewardTwoData[i].rewardText1;
            TextMeshProUGUI rewardText2 = all_ExpeditionRewardTwoData[i].rewardText2;

            rewardText1.text = (rewardData.allFirstRewardAmounts[i]).ToString();
            rewardText2.text = (rewardData.allSecondRewardAmounts[i]).ToString();
        }
    }



    public void OnClick_ExpaditionActive(int _Index)
    {
        print("Runnig State");
        UiManager.instance.homeUi.expeditionState = ExpeditionState.running;
        UiManager.instance.homeUi.CheckExpeditionState();
        DataManager.instance.all_ExpeditionRunningStatus[0] = true;
        DataManager.instance.expeditionOneIndex = _Index;

        expeditionRunningUI.gameObject.SetActive(true);


        expeditionRunningUI.SetExpeditionRunningData();
        //go_ExpaditionTimerScreen.SetExpaditionProcessingData(reward1Icon, reward1Amount, reward2Icon, reward2Amount);

    }

    public void OnClick_ExpaditionScreenClose()
    {
        //expeditionRunningUI.gameObject.SetActive(false);
    }


}
