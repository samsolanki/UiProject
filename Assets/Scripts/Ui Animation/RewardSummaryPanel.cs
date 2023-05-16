using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RewardSummaryPanel : MonoBehaviour
{

    [SerializeField] private Image rewardIcon;
    [SerializeField] private TextMeshProUGUI rewardAmountText;


    public void SetRewardSummaryData(Sprite _rewardIcon , string _rewardAmount)
    {
        rewardIcon.sprite = _rewardIcon;
        rewardAmountText.text = _rewardAmount.ToString();
    }

    public void OnClick_ClaimRewardButton()
    {
        this.gameObject.SetActive(false);
    }

}
