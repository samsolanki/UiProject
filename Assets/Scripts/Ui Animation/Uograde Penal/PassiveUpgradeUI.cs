using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class PassiveUpgradeUI : MonoBehaviour
{
    [Header("Required Scripts")]
    [SerializeField] private PassiveRewardInfoUI rewardInfo;


    [Header("Panel")]
    [SerializeField] private GameObject go_PassiveUpgradeSelectionPanel;
    [SerializeField] private GameObject go_PassiveUpgradeRewaredPanal;

    [SerializeField] private Button upgradeButton;
    [SerializeField] private float animationDuration = .2f;
    [SerializeField] private float upgradeRewardedAnimationDuration = .2f;
    [SerializeField] private float randomEffectDuration = 1.5f;

    [SerializeField] private GameObject[] allUpgrades;

    [SerializeField] private Image[] allSelectedGlowBG;
    [SerializeField] private TextMeshProUGUI[] allLeveltext;

    private int selectedPowerupIndex;

    private List<int> list_AvailableIndex = new List<int>();


    private void OnEnable()
    {
        for (int i = 0; i < allSelectedGlowBG.Length; i++)
        {
            allSelectedGlowBG[i].gameObject.SetActive(false);
        }
    }


    //CALLBACK FUNCTION WHEN CLICK UPGRADE BUTTON IN PASSIVE UPGRADE
    public void OnClickUpgradeButton()
    {
       
        CheckAvailablePassive();

        upgradeButton.interactable = false;

        StartCoroutine(SelectRandomUpgrade());
        
        Sequence seq = DOTween.Sequence();
        seq.Append(upgradeButton.transform.DOScale(new Vector3(1.1f, 1.1f, 1.1f), animationDuration).SetEase(Ease.OutSine)).
                    Append(upgradeButton.transform.DOScale(new Vector3(1f, 1f, 1f), animationDuration).SetEase(Ease.InSine));    
    }

   
    //RANDOM SELECTION EFFECT 
    private IEnumerator SelectRandomUpgrade()
    {
        int randomLoopCount = Random.Range(10, 15);

        int previousIndex = 0;

        UiManager.instance.CanChangeMenus = false;

        for (int i = 0; i < randomLoopCount; i++)
        {
            selectedPowerupIndex = Random.Range(0, list_AvailableIndex.Count);
            allSelectedGlowBG[previousIndex].gameObject.SetActive(false);
            allSelectedGlowBG[selectedPowerupIndex].gameObject.SetActive(true);
            previousIndex = selectedPowerupIndex;
            yield return new WaitForSeconds(0.1f);
        }

        list_AvailableIndex.Clear();

        rewardInfo.SetRewardPanelInfo(selectedPowerupIndex);
        Sequence seq = DOTween.Sequence();
        seq.Append(allUpgrades[selectedPowerupIndex].transform.DOScale(1.2f, upgradeRewardedAnimationDuration).SetEase(Ease.Linear))
                    .Append(allUpgrades[selectedPowerupIndex].transform.DOScale(1, upgradeRewardedAnimationDuration).SetEase(Ease.Linear)).SetLoops(5).
                    OnComplete(ShowRewardPanel);
    }

    //ACTIVE REWARDED PANEL
    private void ShowRewardPanel()
    {
        UiManager.instance.CanChangeMenus = true;
        go_PassiveUpgradeSelectionPanel.SetActive(false);
        go_PassiveUpgradeRewaredPanal.SetActive(true);
        upgradeButton.interactable = true;
    }

    //CHECK IF PASSIVE UPGRADE IS UP MAX PASSIVE LEVEL THEN SKIP THAT UPGRADE
    private void CheckAvailablePassive()
    { 
        for(int i = 0; i < allSelectedGlowBG.Length; i++)
        {
            if (PassiveUpgradeManager.Instance.GetCurrentPassivesLevel(i) < PassiveUpgradeManager.Instance.maxPassiveLevel)
            {
                list_AvailableIndex.Add(i);
            }
        }

        // if everything upgraded, code here


    }

    //SET LEVEL TEXT IN PASSIVE UPGRADE MENU 
    public void SetPassiveUpgradeLevelText()
    {
        for(int  i = 0; i < allLeveltext.Length; i++)
        {
            allLeveltext[i].text = PassiveUpgradeManager.Instance.GetCurrentPassivesLevel(i).ToString();
        }
    }

    public int SelectedPowerupIndex
    {
        get
        {
            return selectedPowerupIndex;
        }
    }

    public Image[] AllGlowBG
    {
        get
        {
            return allSelectedGlowBG;
        }
    }

    public Button UpgradeButton
    {
        get
        {
            return upgradeButton;
        }
    }



}
