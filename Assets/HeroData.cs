using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroData : MonoBehaviour
{
    // profile
    public int heroID;
    public GameObject heroMode;
    public string str_HeroName;
    public int currentLevel;
    public int all_UpgradePrices;
    public int currentCards;
    public int requireCardsToUnlock;


    [Space]

    // Stats
    public float flt_MoveSpeed;
    public float flt_MaxHealth;
    public float flt_Damage;
    public float flt_FireRate;
}
