using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{

    public static DataManager instance;


    public bool[] all_ExpeditionRunningStatus;

    public bool isSoundTurnOn;
    public bool isMusicTurnOn;
    public bool isHighGraphicsTurnOn;


    public int playerLevel;


    private void OnEnable()
    {
        
    }

    private void Awake()
    {
        if (instance != this || instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        //isSoundTurnOn = UiManager.instance.settingUI.SoundToggleButton;
        //isMusicTurnOn = UiManager.instance.settingUI.MusicToggleButton;
        //isHighGraphicsTurnOn = UiManager.instance.settingUI.GraphicsToggleButton;
    }

}
