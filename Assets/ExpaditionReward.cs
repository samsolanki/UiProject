using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ExpaditionReward : MonoBehaviour
{
    [SerializeField] private int[] allFirstRewardAmounts;
    [SerializeField] private int[] allSecondRewardAmounts;


    [SerializeField] private GameObject[] allExpaditionObjects;
    [SerializeField] private GameObject[] allExpaditionObjectsWithAds;

    private int levelMultiplier = 100;


    private bool isRewardInProcess;

    
    private void OnEnable()
    {
        
    }

    private void Start()
    {
        int rewardToAddInEachSlot = DataManager.instance.playerLevel * levelMultiplier;
        for (int i = 0; i < allExpaditionObjects.Length; i++)
        {
            TextMeshProUGUI rewardText1 = allExpaditionObjects[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>();
            TextMeshProUGUI rewardText2 = allExpaditionObjects[i].transform.GetChild(2).GetComponent<TextMeshProUGUI>();

            rewardText1.text = (allFirstRewardAmounts[i] + rewardToAddInEachSlot).ToString();
            rewardText2.text = (allSecondRewardAmounts[i] + rewardToAddInEachSlot).ToString();
        }

        for(int i =0; i < allExpaditionObjectsWithAds.Length; i++)
        {
            TextMeshProUGUI rewardText1 = allExpaditionObjectsWithAds[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>();
            TextMeshProUGUI rewardText2 = allExpaditionObjectsWithAds[i].transform.GetChild(2).GetComponent<TextMeshProUGUI>();

            rewardText1.text = (allFirstRewardAmounts[i] + rewardToAddInEachSlot).ToString();
            rewardText2.text = (allSecondRewardAmounts[i] + rewardToAddInEachSlot).ToString();
        }
    }


}
