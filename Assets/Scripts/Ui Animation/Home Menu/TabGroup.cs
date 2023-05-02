using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabGroup : MonoBehaviour
{
    [SerializeField] private Button[] tabsButtons;
    [SerializeField] private GameObject[] tabs;
    private int currentActiveIndex = 0;
    private HomePenalAnimation homePenal;

    private void Start()
    {
        homePenal = GetComponentInParent<HomePenalAnimation>();
    }


    private void Update()
    {
        for(int i = 0; i < tabs.Length; i++)
        {
            if(i == homePenal.GetCurrentIndex)
            {
                tabs[i].SetActive(true);
                tabsButtons[i].GetComponent<Image>().color = Color.green;
            }
            else
            {
                tabs[i].SetActive(false);
                tabsButtons[i].GetComponent<Image>().color = Color.white;
            }
        }
    }

    public void OnOpenTab1ButtonCallback(int index)
    {
        homePenal.GetCurrentIndex = index;
    }

    public void OnOpenTab2ButtonCallback(int index)
    {
        homePenal.GetCurrentIndex = index;
    }


}
