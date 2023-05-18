using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ExpaditionReward : MonoBehaviour
{
    public Button btn_ExpanditionButton1, btn_ExpanditionButton2;

    [SerializeField] private ExpaditionPanelUI expanditionUI;

    [SerializeField] private int[] allFirstRewardAmounts;
    [SerializeField] private int[] allSecondRewardAmounts;

    public ExpaditionRewardData[] all_ExpaditionRewardData;
    public ExpaditionRewardData[] all_AdsExpaditionRewardData;



    [SerializeField] private Sprite expaditionRunningSprite;
    [SerializeField] private Sprite expaditionCompleteSprite;
    [SerializeField] private Sprite expaditionNormalSprite;

    [SerializeField] private float expanditionTimer1 = 30;
    [SerializeField] private float expanditionTimer2 = 30;

    private int levelMultiplier = 100;


    private void Start()
    {
        int rewardToAddInEachSlot = DataManager.instance.playerLevel * levelMultiplier;
        for (int i = 0; i < all_ExpaditionRewardData.Length; i++)
        {
            TextMeshProUGUI rewardText1 = all_ExpaditionRewardData[i].rewardText1;
            TextMeshProUGUI rewardText2 = all_ExpaditionRewardData[i].rewardText2;

            rewardText1.text = (allFirstRewardAmounts[i] + rewardToAddInEachSlot).ToString();
            rewardText2.text = (allSecondRewardAmounts[i] + rewardToAddInEachSlot).ToString();
        }

        for(int i =0; i < all_AdsExpaditionRewardData.Length; i++)
        {
            TextMeshProUGUI rewardText1 = all_AdsExpaditionRewardData[i].rewardText1;
            TextMeshProUGUI rewardText2 = all_AdsExpaditionRewardData[i].rewardText2;

            rewardText1.text = (allFirstRewardAmounts[i] + rewardToAddInEachSlot).ToString();
            rewardText2.text = (allSecondRewardAmounts[i] + rewardToAddInEachSlot).ToString();
        }
    }

    public void ShowTimer()
    {
        btn_ExpanditionButton1.GetComponent<Image>().sprite = expaditionRunningSprite;
        expanditionUI.ExpanditionProcessingData.txt_expanditionTimer.text = expanditionTimer1.ToString("F0");
    }

    private void Update()
    {
       /* if (DataManager.instance.isExpaditionStarted1)
        {
            expanditionTimer1 -= Time.deltaTime;
         

            if (expanditionTimer1 <= 0)
            {
                expanditionUI.whenCompleteAndTouchs1 = true;
                expanditionTimer1 = 30;
                btn_ExpanditionButton1.transform.GetChild(1).gameObject.SetActive(true);
                btn_ExpanditionButton1.GetComponent<Image>().sprite = expaditionCompleteSprite;
                expanditionUI.ExpanditionProcessingData.gameObject.SetActive(false);
                DataManager.instance.isExpaditionStarted1 = false;
            }
        }else if(!DataManager.instance.isExpaditionStarted1 && expanditionUI.doNotStartExpaditionAtFirstLoad1)
        {
            DataManager.instance.isExpaditionStarted1 = false;
            expanditionUI.whenCompleteAndTouch1 = true;
            expanditionTimer1 = 30;
            btn_ExpanditionButton1.transform.GetChild(1).gameObject.SetActive(true);
            btn_ExpanditionButton1.GetComponent<Image>().sprite = expaditionNormalSprite;
            expanditionUI.ExpanditionProcessingData.gameObject.SetActive(false);
            DataManager.instance.isExpaditionStarted1 = false;
            btn_ExpanditionButton1.transform.GetChild(1).gameObject.SetActive(false);
        }

        if (DataManager.instance.isExpaditionStarted2)
        {
            expanditionTimer2 -= Time.deltaTime;
            btn_ExpanditionButton2.GetComponent<Image>().sprite = expaditionRunningSprite;
            expanditionUI.ExpanditionProcessingData.txt_expanditionTimer.text = expanditionTimer2.ToString("n2");
            if (expanditionTimer2 <= 0)
            {
                expanditionUI.doNotStartExpaditionAtFirstLoad1 = false;
                expanditionUI.whenCompleteAndTouch2 = true;
                expanditionTimer2 = 30;
                btn_ExpanditionButton2.transform.GetChild(1).gameObject.SetActive(true);
                btn_ExpanditionButton2.GetComponent<Image>().sprite = expaditionCompleteSprite;
                expanditionUI.ExpanditionProcessingData.gameObject.SetActive(false);
                DataManager.instance.isExpaditionStarted2 = false;
            }
        }
        else if (!DataManager.instance.isExpaditionStarted2 && expanditionUI.doNotStartExpaditionAtFirstLoad2)
        {
            DataManager.instance.isExpaditionStarted2 = false;
            expanditionUI.doNotStartExpaditionAtFirstLoad2 = false;
            expanditionUI.whenCompleteAndTouch2 = true;
            expanditionTimer2 = 30;
            btn_ExpanditionButton2.transform.GetChild(1).gameObject.SetActive(true);
            btn_ExpanditionButton2.GetComponent<Image>().sprite = expaditionNormalSprite;
            expanditionUI.ExpanditionProcessingData.gameObject.SetActive(false);
            btn_ExpanditionButton2.transform.GetChild(1).gameObject.SetActive(false);
            DataManager.instance.isExpaditionStarted2 = false;
        }*/
    }


    public void OnClick_ExpaditionCompleteButton1()
    {
        if (expanditionUI.whenCompleteAndTouch1)
        {
            expanditionUI.whenCompleteAndTouch1 = false;
            btn_ExpanditionButton1.GetComponent<Image>().sprite = expaditionNormalSprite;
            btn_ExpanditionButton1.transform.GetChild(1).gameObject.SetActive(false);
        }
    }

    public void OnClick_ExpaditionCompleteButton2()
    {
        if (expanditionUI.whenCompleteAndTouch2)
        {
            expanditionUI.whenCompleteAndTouch2 = false;
            btn_ExpanditionButton2.GetComponent<Image>().sprite = expaditionNormalSprite;
            btn_ExpanditionButton2.transform.GetChild(1).gameObject.SetActive(false);
        }
    }
}
