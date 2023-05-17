using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DailyMissionData : MonoBehaviour
{
    [SerializeField] private Image img_RewardIcon;
    [SerializeField] private TextMeshProUGUI txt_RewardAmount;
    [SerializeField] private TextMeshProUGUI txt_AmountText;
    [SerializeField] private Sprite img_DailyMissionComplate;
    public Slider slider_RewardComplate;
    [SerializeField] private Button btn_Claim;

    public float currentComplateAmount = 0;
    public float requireAmountToComplate = 1;

    public bool isDailyMissionComplate;

    // Start is called before the first frame update
    void Start()
    {
        btn_Claim.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if(currentComplateAmount == requireAmountToComplate)
        {
            isDailyMissionComplate = true;
            btn_Claim.gameObject.SetActive(true);
        }
        txt_AmountText.text = currentComplateAmount + " / " + requireAmountToComplate;
    }


    public void OnClick_DailyMissionClaimButton()
    {
        btn_Claim.interactable = false;
        UiManager.instance.rewardSummaryPanel.SetRewardSummaryData(img_RewardIcon.sprite, txt_RewardAmount.text);
        UiManager.instance.rewardSummaryPanel.gameObject.SetActive(true);
        slider_RewardComplate.value = 0.99f;
        img_RewardIcon.sprite = img_DailyMissionComplate;
    }
}
