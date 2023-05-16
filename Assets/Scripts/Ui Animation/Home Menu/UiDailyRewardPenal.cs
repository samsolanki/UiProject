using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiDailyRewardPenal : MonoBehaviour
{

    [SerializeField] private Button[] allDaysRewardButtons;


    private int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < allDaysRewardButtons.Length; i++)
        {
            allDaysRewardButtons[i].interactable = false;
        }
        allDaysRewardButtons[index].interactable = true;
        Debug.Log(allDaysRewardButtons.Length);
        
    }

    private void Update()
    {
        
    }

    public void OnClick_ActiveNextRewardButton(int _buttonIndex)
    {
        if (_buttonIndex == index)
        {
            allDaysRewardButtons[index].interactable = false;
            if (index >= allDaysRewardButtons.Length - 1)
            {
                index = -1;
                print("index is big them length");
            }

            Image rewardIcon = allDaysRewardButtons[index].transform.GetChild(0).GetComponent<Image>();
            string rewardAmount = allDaysRewardButtons[index].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text;
            print(rewardIcon.gameObject.name);

            UiManager.instance.rewardSummaryPanel.SetRewardSummaryData(rewardIcon.sprite , rewardAmount);
            UiManager.instance.rewardSummaryPanel.gameObject.SetActive(true);
            index++;
            allDaysRewardButtons[index].interactable = true;
        }

    }
}
