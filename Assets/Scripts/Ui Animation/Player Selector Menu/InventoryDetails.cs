using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryDetails : MonoBehaviour
{
    [SerializeField] private int index;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public int InventoryIndex
    {
        get
        {
            return index;
        }
        set
        {
            index = value;
        }
    }
}
