using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomePenalAnimation : MonoBehaviour
{
    [SerializeField] private GameObject trainingPenal;
    private int currentIndex;



    public void OnopenTraningPenal1ButtonCallback(int index)
    {
        currentIndex = index;
        trainingPenal.SetActive(true);
    }

    public void OnopenTraningPenal2ButtonCallback(int index)
    {
        currentIndex = index;
        trainingPenal.SetActive(true);
    }

    public void OnHideTraningPenalButtonCallback()
    {
        trainingPenal.SetActive(false);
    }

    public int GetCurrentIndex
    {
        get
        {
            return currentIndex;
        }
        set
        {
            currentIndex = value;
        }
    }

    // public void OnClick_ButtonFunction()
}
