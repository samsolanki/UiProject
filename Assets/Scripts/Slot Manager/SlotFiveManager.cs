using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotFiveManager : MonoBehaviour
{
    [SerializeField] private Button slotFive;

    [SerializeField] private Image img_PlusSign;

    public List<GameObject> list_Anything = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        CheckIfAnyItmesCanAdd();
    }

    public void CheckIfAnyItmesCanAdd()
    {
        if (list_Anything.Count > 0)
        {
            img_PlusSign.gameObject.SetActive(true);
            slotFive.interactable = true;
        }
        else
        {
            img_PlusSign.gameObject.SetActive(false);
            slotFive.interactable = false;
        }

    }
}
