using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingUI : MonoBehaviour
{

    [SerializeField] private Toggle soundToggleButton;
    [SerializeField] private Toggle musicToggleButton;
    [SerializeField] private Toggle graphicsToggleButton;




    public void OnClick_SettingScreenClose()
    {
        this.gameObject.SetActive(false);
    }
}
