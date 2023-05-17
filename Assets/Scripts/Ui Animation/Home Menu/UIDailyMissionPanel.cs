using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIDailyMissionPanel : MonoBehaviour
{

    [SerializeField] private DailyMissionData[] all_DailyMissions; // REFERANCE OF ALL ACTIVE DAILY MISSIONS


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            all_DailyMissions[0].currentComplateAmount += 1;
            all_DailyMissions[0].slider_RewardComplate.value = all_DailyMissions[0].currentComplateAmount / all_DailyMissions[0].requireAmountToComplate;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            all_DailyMissions[1].currentComplateAmount += 1;
            all_DailyMissions[1].slider_RewardComplate.value = all_DailyMissions[1].currentComplateAmount / all_DailyMissions[1].requireAmountToComplate;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            all_DailyMissions[2].currentComplateAmount += 1;
            all_DailyMissions[2].slider_RewardComplate.value = all_DailyMissions[2].currentComplateAmount / all_DailyMissions[2].requireAmountToComplate;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            all_DailyMissions[3].currentComplateAmount += 1;
            all_DailyMissions[3].slider_RewardComplate.value = all_DailyMissions[3].currentComplateAmount / all_DailyMissions[3].requireAmountToComplate;
        }

       




    }
}
