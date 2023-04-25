using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class NavigationMenuAnimation : MonoBehaviour
{
    [SerializeField] private Button[] navigationButton;

    private int selectedIndex = 2;

    private void Start()
    {
        
    }

    public void ActivatedButton(int index)
    {
        selectedIndex = index;

        if(selectedIndex == index)
        {
            navigationButton[selectedIndex].transform.localScale = new Vector3(1.2f, navigationButton[selectedIndex].transform.localScale.y, navigationButton[selectedIndex].transform.localScale.z);
        }
    }


}
