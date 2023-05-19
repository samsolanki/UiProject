using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RewardSummaryUI : MonoBehaviour
{

    [SerializeField] private Image[] allRewardIcons;
    [SerializeField] private TextMeshProUGUI rewardAmountText;


    public void SetRewardSummaryData(Sprite _rewardIcon , string _rewardAmount)
    {
        allRewardIcons[0].gameObject.SetActive(true);
        allRewardIcons[0].transform.GetChild(0).GetComponent<Image>().sprite = _rewardIcon;
        allRewardIcons[0].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = _rewardAmount.ToString();
    }


    public void SetMultiplRewardSummaryData(List<Sprite> allRewardSprite , List<string> allRewardAmount)
    {
        for(int i =0; i < allRewardSprite.Count; i++)
        {
            allRewardIcons[i].gameObject.SetActive(true);

            allRewardIcons[i].transform.GetChild(0).GetComponent<Image>().sprite = allRewardSprite[i];
            allRewardIcons[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = allRewardAmount[i];
        }
    }

    public void OnClick_ClaimRewardButton()
    {
        this.gameObject.SetActive(false);
        for (int i = 0; i < allRewardIcons.Length; i++)
        {
            allRewardIcons[i].gameObject.SetActive(false);
        }
    }

}
