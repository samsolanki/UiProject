using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSlotManager : MonoBehaviour
{
    public static PlayerSlotManager instance;


    public bool isHeadItemEquipped;


    private void Awake()
    {
        instance = this;
    }
}
