using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpaditionPanelUI : MonoBehaviour
{

    [SerializeField] private int myPanelId;

    [SerializeField] private ExpaditionReward rewardData;

    [SerializeField] private GameObject go_ExpaditionScreen;
    [SerializeField] private ExpanditionProcessingData go_ExpaditionTimerScreen;

    [SerializeField] private bool isExpaditionStarted;

    public bool whenCompleteAndTouch1;
    public bool whenCompleteAndTouch2;


    public bool doNotStartExpaditionAtFirstLoad1;
    public bool doNotStartExpaditionAtFirstLoad2;

    public int currentIndex;

    private void OnEnable()
    {
        //if (DataManager.instance.isExpaditionStarted1)
        //{
        //    go_ExpaditionTimerScreen.gameObject.SetActive(true);
        //}
        //else
        //{
        //    go_ExpaditionTimerScreen.gameObject.SetActive(false);
        //}

        //if (DataManager.instance.isExpaditionStarted2)
        //{
        //    go_ExpaditionTimerScreen.gameObject.SetActive(true);

        //}
        //else
        //{
        //    go_ExpaditionTimerScreen.gameObject.SetActive(false);
        //}
    }

    public ExpanditionProcessingData ExpanditionProcessingData
    {
        get
        {
            return go_ExpaditionTimerScreen;
        }
    }


    public void OnClick_ExpaditionActive(int _Index)
    {
            //DataManager.instance.isExpaditionStarted1 = true;
            go_ExpaditionTimerScreen.gameObject.SetActive(true);
            for (int i = 0; i < rewardData.all_ExpaditionRewardData.Length; i++)
            {
                if (i == _Index)
                {
                    Sprite reward1Icon = rewardData.all_ExpaditionRewardData[i].img_RewardIcon1.sprite;
                    Sprite reward2Icon = rewardData.all_ExpaditionRewardData[i].img_RewardIcon2.sprite;

                    string reward1Amount = rewardData.all_ExpaditionRewardData[i].rewardText1.text;
                    string reward2Amount = rewardData.all_ExpaditionRewardData[i].rewardText2.text;

                    go_ExpaditionTimerScreen.SetExpaditionProcessingData(reward1Icon, reward1Amount, reward2Icon, reward2Amount);
                }
            }
        
    }

    public void OnClick_AdsExpaditionActive(int _Index)
    {
            //DataManager.instance.isExpaditionStarted2 = true;
            go_ExpaditionTimerScreen.gameObject.SetActive(true);
            for (int i = 0; i < rewardData.all_AdsExpaditionRewardData.Length; i++)
            {
                if (i == _Index)
                {
                    Sprite reward1Icon = rewardData.all_AdsExpaditionRewardData[i].img_RewardIcon1.sprite;
                    Sprite reward2Icon = rewardData.all_AdsExpaditionRewardData[i].img_RewardIcon2.sprite;

                    string reward1Amount = rewardData.all_AdsExpaditionRewardData[i].rewardText1.text;
                    string reward2Amount = rewardData.all_AdsExpaditionRewardData[i].rewardText2.text;

                    go_ExpaditionTimerScreen.SetExpaditionProcessingData(reward1Icon, reward1Amount, reward2Icon, reward2Amount);
                }
            }
    }


    public void OnClick_ExpaditionScreenClose()
    {
        go_ExpaditionTimerScreen.gameObject.SetActive(false);
    }

    public void OnClick_FinishExpadition()
    {
        doNotStartExpaditionAtFirstLoad1 = true;
        go_ExpaditionTimerScreen.gameObject.SetActive(false);
        go_ExpaditionScreen.SetActive(true);
        //DataManager.instance.isExpaditionStarted1 = false;
    }

    public void OnClick_FinishExpadition2()
    {
        doNotStartExpaditionAtFirstLoad2 = true;
        go_ExpaditionTimerScreen.gameObject.SetActive(false);
        go_ExpaditionScreen.SetActive(true);
        //DataManager.instance.isExpaditionStarted2 = false;
    }

}
