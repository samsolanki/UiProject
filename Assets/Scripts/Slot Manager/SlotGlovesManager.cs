using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotGlovesManager : MonoBehaviour
{
    [SerializeField] private Button slotFour;

    [SerializeField] private Image img_PlusSign;

    public List<GameObject> list_Gloves = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        CheckIfAnyItmesCanAdd();
    }

    public void CheckIfAnyItmesCanAdd()
    {
        if (list_Gloves.Count > 0)
        {
            img_PlusSign.gameObject.SetActive(true);
            slotFour.interactable = true;
        }
        else
        {
            img_PlusSign.gameObject.SetActive(false);
            slotFour.interactable = false;
        }

    }
}
