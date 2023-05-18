using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ExpanditionProcessingData : MonoBehaviour
{
    public TextMeshProUGUI txt_expanditionTimer;
    public Slider slider_ExpanditionSlider;


    [Header("Reward 1 Data")]
    [SerializeField] private Image rewardIcon1;
    [SerializeField] private TextMeshProUGUI rewardAmount1;

    [Header("Reward 2 Data")]
    [SerializeField] private Image rewardIcon2;
    [SerializeField] private TextMeshProUGUI rewardAmount2;

    public void SetExpaditionProcessingData(Sprite _reward1Sprite , string _reward1Amount , Sprite _reward2Sprite , string _reward2Amount)
    {
        rewardIcon1.sprite = _reward1Sprite;
        rewardAmount1.text = _reward1Amount;

        rewardIcon2.sprite = _reward2Sprite;
        rewardAmount2.text = _reward2Amount;
    }
}
