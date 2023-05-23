using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotArrmorManager : MonoBehaviour
{
    [SerializeField] private Button slotThree;

    [SerializeField] private Image img_PlusSign;

    public List<GameObject> list_Arrmor = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        CheckIfAnyItmesCanAdd();
    }

    public void CheckIfAnyItmesCanAdd()
    {
        if (list_Arrmor.Count > 0)
        {
            img_PlusSign.gameObject.SetActive(true);
            slotThree.interactable = true;
        }
        else
        {
            img_PlusSign.gameObject.SetActive(false);
            slotThree.interactable = false;
        }

    }
}
