using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class UpgradeSelectorPenal : MonoBehaviour
{

    [Header("Require Scripts")]
    [SerializeField] private UpgradePenalAnimation upgradePenal;
    [SerializeField] private UpdateSummary updateSummary;

    [SerializeField] private GameObject[] allUpgrades;
    //[SerializeField] private Image headingImage;
    [SerializeField] private CanvasGroup headingImage;
    [SerializeField] private CanvasGroup continueButton;

    [SerializeField] private float animationDuration = 0.5f;

    bool isUpgradeApplied;

    // Start is called before the first frame update
    void Start()
    {
        isUpgradeApplied = true;
        continueButton.DOFade(0, 0.01f);
        // headingImage.DOFade(0, animationDuration);
    }

    // Update is called once per frame
    void Update()
    {
        if (!upgradePenal.GetSelection() && !isUpgradeApplied)
        {
            updateSummary = allUpgrades[upgradePenal.GetSelectedIndex()].gameObject.GetComponent<UpdateSummary>();
            StartCoroutine(ChangePenalToUpgradeSummary());
        }
    }

    IEnumerator ChangePenalToUpgradeSummary()
    {
        yield return new WaitForSeconds(0.5f);
        upgradePenal.gameObject.SetActive(false);
        UpdateSummaryAnimation();

    }

    private void UpdateSummaryAnimation()
    {
        allUpgrades[upgradePenal.GetSelectedIndex()].gameObject.SetActive(true);
        allUpgrades[upgradePenal.GetSelectedIndex()].transform.DOScale(new Vector3(1,1,1) ,animationDuration)
            .OnComplete(HeadingtextAnimation);
    }

    private void HeadingtextAnimation()
    {
        headingImage.DOFade(1, animationDuration).OnComplete(NameTextAnimation);
    }


    private void NameTextAnimation()
    {
        updateSummary.GetNameText().DOFade(1, animationDuration).OnComplete(LevelTextAnimation);
    }
    private void LevelTextAnimation()
    {
        updateSummary.GetLevelText().DOFade(1, animationDuration).OnComplete(DescriptionTextAnimation);
    }

    private void DescriptionTextAnimation()
    {
        updateSummary.GetDescriptiontext().DOFade(1, animationDuration).OnComplete(ContinueButtonAnimation);
    }

    private void ContinueButtonAnimation()
    {
        continueButton.DOFade(1, animationDuration);
    }

    public void OnContinueButtonCallback()
    {
        isUpgradeApplied = true;
    }

    public void SetIsUpgradeApplied(bool value)
    {
        isUpgradeApplied = value;
    }
}
