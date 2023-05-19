using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCalculation : MonoBehaviour
{
    public static TimeCalculation instance;


    public float expeditionOneTimer = 30f;


    public float hours;
    public float minutes;
    public float seconds;

    public float currentExpeditionOneTimer;


    private void Awake()
    {
        if (instance != this || instance == null)
        {
            instance = this;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (DataManager.instance.all_ExpeditionRunningStatus[0])
        {
            print("Method Called");
            CalcuateExpeditionOneTime();
        }        
    }

    private void CalcuateExpeditionOneTime()
    {
        currentExpeditionOneTimer -= Time.deltaTime;

        if(currentExpeditionOneTimer <= 0)
        {
            currentExpeditionOneTimer = expeditionOneTimer;
            UiManager.instance.homeUi.CompleteExpadition();

        }
        UiManager.instance.homeUi.ExpeditionOneTimer(currentExpeditionOneTimer);
    }
    
    public void ResetExpeditionOneTimer()
    {
        currentExpeditionOneTimer = expeditionOneTimer;
    }

}
