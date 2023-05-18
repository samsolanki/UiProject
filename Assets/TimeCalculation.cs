using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCalculation : MonoBehaviour
{
    [SerializeField] private ExpaditionReward expaditionRewardScreen;

    // Update is called once per frame
    void Update()
    {
        /*if (DataManager.instance.all_ExpeditionRunningStatus[0])
        {
            //CalcuateExpeditionOneTime();
        }        */
    }

    private void CalcuateExpeditionOneTime()
    {
        expaditionRewardScreen.ShowTimer();
    }
}
