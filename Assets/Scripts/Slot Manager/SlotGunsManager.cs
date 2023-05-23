using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotGunsManager : MonoBehaviour
{
    public static SlotGunsManager instance;


    [SerializeField] private Button slotTwo;

    [SerializeField] private Image img_PlusSign;

    public List<Sprite> list_Guns = new List<Sprite>();

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        CheckIfAnyItmesCanAdd();
    }

    public void CheckIfAnyItmesCanAdd()
    {
        if (list_Guns.Count > 0)
        {
            img_PlusSign.gameObject.SetActive(true);
            slotTwo.interactable = true;
        }
        else
        {
            img_PlusSign.gameObject.SetActive(false);
            slotTwo.interactable = false;
        }

    }
}
