using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DailyMissionData : MonoBehaviour
{

    [SerializeField] public DailyManagerSO dailyMissionSO;

    public Image img_RewardIcon;
    public TextMeshProUGUI txt_Description;
    public TextMeshProUGUI txt_RewardAmount;
    public TextMeshProUGUI txt_SliderAmountText;
    [SerializeField] private Sprite img_DailyMissionComplate;
    public Slider slider_RewardComplate;
    [SerializeField] private Button btn_Claim;

    public bool isDailyMissionComplate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    public void OnClick_DailyMissionClaimButton()
    {
        btn_Claim.interactable = false;
        UiManager.instance.rewardSummaryUI.SetRewardSummaryData(img_RewardIcon.sprite, txt_RewardAmount.text);
        UiManager.instance.rewardSummaryUI.gameObject.SetActive(true);
        slider_RewardComplate.value = 0.99f;
        img_RewardIcon.sprite = img_DailyMissionComplate;
    }
}
