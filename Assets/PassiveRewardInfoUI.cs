using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class PassiveRewardInfoUI : MonoBehaviour
{

    [SerializeField] private GameObject passiveUpgradeSelection;

    [SerializeField] private Image img_PassiveUpgradeIcon;
    [SerializeField] private Image img_PassiveUpgradeLevelIcon;
    [SerializeField] private TextMeshProUGUI text_PassiveUpgradeName;
    [SerializeField] private TextMeshProUGUI text_PassiveUpgradeLevel;
    [SerializeField] private TextMeshProUGUI text_PassiveUpgradeDesc;
    [SerializeField] private CanvasGroup continueButton;

    [SerializeField] private float fadeAnimationDuration = 0.5f;

    private PassiveUpgradeUI passiveUpgradeUI;

    private void OnEnable()
    {
        PassiveUpgradePanelAnimationStart();
    }


    private void Start()
    {
        passiveUpgradeUI = GetComponentInParent<PassiveUpgradeUI>();
    }

    public void SetRewardPanelInfo(int _rewardedPassiveIndex)
    {
        PassiveUpgradeManager.Instance.IncreasePassiveUpgradeCurrentLevel(_rewardedPassiveIndex);
        img_PassiveUpgradeLevelIcon.GetComponentInChildren<TextMeshProUGUI>().text = PassiveUpgradeManager.Instance.GetCurrentPassivesLevel(_rewardedPassiveIndex).ToString();
        text_PassiveUpgradeLevel.text = "Level " + PassiveUpgradeManager.Instance.GetCurrentPassivesLevel(_rewardedPassiveIndex).ToString();
        text_PassiveUpgradeName.text = PassiveUpgradeManager.Instance.GetCurrentPassiveUpgradeName(_rewardedPassiveIndex);
        text_PassiveUpgradeDesc.text = PassiveUpgradeManager.Instance.GetCurrentPassiveUpgradeDesc(_rewardedPassiveIndex);
    }

    

    private void ResetAllPanels()
    {
        // alpha 0 for all images

        //image.sprites
        /*Color tempColor = img_PassiveUpgradeIcon.color;
        tempColor.a = 0;
        img_PassiveUpgradeIcon.color = tempColor;

        Color tempText = text_PassiveUpgradeName.color;
        tempText.a = 0;
        text_PassiveUpgradeName.color = tempText;*/

        img_PassiveUpgradeIcon.DOFade(0, 0.01f);
        text_PassiveUpgradeName.DOFade(0, 0.01f);
        text_PassiveUpgradeLevel.DOFade(0, 0.01f);
        text_PassiveUpgradeDesc.DOFade(0, 0.01f);
        continueButton.DOFade(0, 0.01f);

    }

    //START PASSIVE REWARDED PANEL ANIMATION
    private void PassiveUpgradePanelAnimationStart()
    {
        Sequence seq = DOTween.Sequence();

        seq.Append(img_PassiveUpgradeIcon.DOFade(1, fadeAnimationDuration)).
            Append(text_PassiveUpgradeName.DOFade(1, fadeAnimationDuration)).
            Append(text_PassiveUpgradeLevel.DOFade(1, fadeAnimationDuration)).
            Append(text_PassiveUpgradeDesc.DOFade(1, fadeAnimationDuration)).
            Append(continueButton.DOFade(1, fadeAnimationDuration));
    }

    public void OnClick_ContinueButton()
    {
        ResetAllPanels();

        for (int i = 0; i < passiveUpgradeUI.AllGlowBG.Length; i++)
        {
            passiveUpgradeUI.AllGlowBG[i].gameObject.SetActive(false);
        }
        passiveUpgradeUI.SetPassiveUpgradeLevelText();
        passiveUpgradeSelection.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
