using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HeadInventoryProperty : MonoBehaviour
{
    public int currentLevel;
    public string name;
    public Sprite sprite;
    public bool isLocked = true;

    public float currentHealth;
    public float[] healthIncrease;

    public int currentMaterials;
    public int[] requireMaterialToLevelUp;
}
