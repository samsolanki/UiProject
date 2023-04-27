using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class NavigationMenuAnimation : MonoBehaviour
{
    [SerializeField] private RectTransform[] navigationButton; // ALL BUTTONS RECT TRANSFORM
    [SerializeField] private TextMeshProUGUI[] menuText;
    [SerializeField] private Image[] menuIcons;

    [SerializeField] private float animationDuration = 0.3f;

    private void Start()
    {
    }


    //BUTTON CALLBACK FUNCTION CALL WHEN BUTTON PRESS
    public void ActivatedButtonCallback(int index)
    {

        print("Method called");
        float startingPosition = 0;


        for (int i = 0; i < navigationButton.Length; i++)
        {
            //I IS EQULS TO IDEX INCREASE SIZE OF BUTTON AND SET ACTIVE THAT BUTTON
            if (i == index)
            {
                navigationButton[i].DOAnchorMin(new Vector2(startingPosition, navigationButton[i].anchorMin.y), animationDuration);
                startingPosition += 0.28f;
                navigationButton[i].DOAnchorMax(new Vector2(startingPosition, 1f), animationDuration);
                menuText[i].GetComponent<RectTransform>().DOAnchorMax(new Vector2(menuText[i].GetComponent<RectTransform>().anchorMax.x, 0.4f), animationDuration);
                menuIcons[i].GetComponent<RectTransform>().DOAnchorMin(new Vector2(menuIcons[i].GetComponent<RectTransform>().anchorMin.x, 0.9f), animationDuration);
                menuIcons[i].GetComponent<RectTransform>().DOAnchorMax(new Vector2(menuIcons[i].GetComponent<RectTransform>().anchorMax.x, 1.0f), animationDuration);
                menuIcons[i].transform.DOScale(new Vector3(1.3f, 1.3f, 1.3f), animationDuration);

            }
            //DECEREASE SIZE OF ALL OTHER BUTTONS
            else
            {
                navigationButton[i].DOAnchorMin(new Vector2(startingPosition, navigationButton[i].anchorMin.y), animationDuration);
                startingPosition += 0.18f;
                navigationButton[i].DOAnchorMax(new Vector2(startingPosition, .9f), animationDuration);
                menuText[i].GetComponent<RectTransform>().DOAnchorMax(new Vector2(menuText[i].GetComponent<RectTransform>().anchorMax.x, 0.1f), animationDuration);
                menuIcons[i].GetComponent<RectTransform>().DOAnchorMin(new Vector2(menuIcons[i].GetComponent<RectTransform>().anchorMin.x,0.5f), animationDuration);
                menuIcons[i].GetComponent<RectTransform>().DOAnchorMax(new Vector2(menuIcons[i].GetComponent<RectTransform>().anchorMax.x,0.5f), animationDuration);
                menuIcons[i].transform.DOScale(new Vector3(1f, 1f, 1f), animationDuration);
            }

        }
    }


}
