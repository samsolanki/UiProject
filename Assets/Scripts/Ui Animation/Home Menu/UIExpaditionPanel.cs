using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIExpaditionPanel : MonoBehaviour
{

    [SerializeField] private GameObject go_ExpaditionScreen;
    [SerializeField] private GameObject go_ExpaditionTimerScreen;

    [SerializeField] private bool isExpaditionStarted;

    private void OnEnable()
    {
        //
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (isExpaditionStarted)
    //    {
    //        go_ExpaditionTimerScreen.SetActive(true);
    //    }
    //    else
    //    {
    //        go_ExpaditionTimerScreen.SetActive(false);
    //    }
    //}

    public void OnClick_ExpaditionActive()
    {
        isExpaditionStarted = true;
    }

}
