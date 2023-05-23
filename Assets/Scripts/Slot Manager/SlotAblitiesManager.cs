using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotAblitiesManager : MonoBehaviour
{
    [SerializeField] private Button slotSix;

    [SerializeField] private Image img_PlusSign;

    public List<GameObject> list_Abilities = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        CheckIfAnyItmesCanAdd();
    }

    public void CheckIfAnyItmesCanAdd()
    {
        if (list_Abilities.Count > 0)
        {
            img_PlusSign.gameObject.SetActive(true);
            slotSix.interactable = true;
        }
        else
        {
            img_PlusSign.gameObject.SetActive(false);
            slotSix.interactable = false;
        }

    }
}
