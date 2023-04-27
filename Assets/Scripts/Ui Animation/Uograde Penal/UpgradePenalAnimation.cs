using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class UpgradePenalAnimation : MonoBehaviour
{
    [Header("Required Scripts")]
    [SerializeField] private UpgradeSelectorPenal upgradeSelectorPenal;

    [SerializeField] private Button upgradeButton;
    [SerializeField] private float animationDuration = .2f;
    [SerializeField] private float randomEffectDuration = 1.5f;

    [SerializeField] private GameObject[] allUpgrades;

    [SerializeField] private Image[] allSelectedGlowBG;
    [SerializeField] private TextMeshProUGUI[] allLeveltext;

    private int selectedIndex;
    int randomIndex;
    bool selectRandomly = false;
    private int currentLevel;

    // Start is called before the first frame update
    void Start()
    {
        for(int i= 0; i <allSelectedGlowBG.Length; i++)
        {
            allSelectedGlowBG[i].gameObject.SetActive(false);
            allLeveltext[i].text = 0.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (selectRandomly)
        {
            randomIndex = Random.Range(0, allSelectedGlowBG.Length);
            for(int i = 0; i < allSelectedGlowBG.Length; i++)
            {
                if(i == randomIndex)
                {
                    allSelectedGlowBG[i].gameObject.SetActive(true);
                }
                else
                {
                    allSelectedGlowBG[i].gameObject.SetActive(false);
                }
                StartCoroutine(DisableRandomlySelectEffect());
            }
        }
    }


    public void OnUpgreadeButtonCallback()
    {
        selectRandomly = true;
        upgradeButton.transform.DOScale(new Vector3(1.1f,1.1f,1.1f) , animationDuration).SetEase(Ease.OutSine).OnComplete(ScaleDownButton);
    }

    private void ScaleDownButton()
    {
        upgradeButton.transform.DOScale(new Vector3(1f, 1f, 1f), animationDuration).SetEase(Ease.InSine);
    }
    

    IEnumerator DisableRandomlySelectEffect()
    {
        upgradeButton.interactable = false;
        yield return new WaitForSeconds(randomEffectDuration);
        selectRandomly = false;
        selectedIndex = randomIndex;
        upgradeButton.interactable = true;
        upgradeSelectorPenal.SetIsUpgradeApplied(false);
    }

    public bool GetSelection()
    {
        return selectRandomly;
    }

    public int GetSelectedIndex()
    {
        return selectedIndex;
    }
}
