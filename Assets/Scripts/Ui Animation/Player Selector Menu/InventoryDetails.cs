using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryDetails : MonoBehaviour
{
    [SerializeField] private int index;


    public int InventoryIndex
    {
        set
        {
            index = value;
        }
    }
}
