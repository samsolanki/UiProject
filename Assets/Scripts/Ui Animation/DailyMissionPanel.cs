using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DailyMissionPanel : MonoBehaviour
{

    [SerializeField] private GameObject[] all_DailyMissions; // REFERANCE OF ALL ACTIVE DAILY MISSIONS

    [SerializeField] private Image[] all_DailyMissionRewardIcons; // REFERANCE OF ALL ACTIVE DAILY MISSIONS REWARD ICONS


    // Start is called before the first frame update
    void Start()
    {
                all_DailyMissionRewardIcons = new Image[all_DailyMissions.Length];
        for(int i = 0; i < all_DailyMissions.Length; i++)
        {
            Image rewardIcon = all_DailyMissions[i].transform.GetChild(0).transform.GetChild(0).gameObject.GetComponent<Image>();

            if(rewardIcon != null)
            {
                all_DailyMissionRewardIcons[i] = rewardIcon;
            }
            else
            {
                Debug.Log("not find image");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
