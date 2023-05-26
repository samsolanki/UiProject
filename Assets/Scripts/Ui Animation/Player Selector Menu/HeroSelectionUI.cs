using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HeroSelectionUI : MonoBehaviour
{
    [SerializeField] private GameObject go_AllHeroParent;


    [SerializeField] private TextMeshProUGUI txt_SelectedHeroName;
    [SerializeField] private TextMeshProUGUI txt_SelectHeroHealth;
    [SerializeField] private TextMeshProUGUI txt_SelectHeroDamage;
    [SerializeField] private TextMeshProUGUI txt_SelectHeroFirerate;


    public void OnClickSelectePlayer(int _selectionIndex)
    {
        txt_SelectedHeroName.text = HeroesManager.Instance.GetHeroName(_selectionIndex);
        if (_selectionIndex == HeroesManager.Instance.GetHeroId(_selectionIndex))
        {
            //allHeros[_selectionIndex].SetActive(true);
        }
        else
        {
            //for(int i =0; i < allHeros.Length; i++)
            {
                //allHeros[i].SetActive(false);
            }
        }
    }

    private void SetSelectedHeroData(int _selectedIndex)
    {
        txt_SelectedHeroName.text = HeroesManager.Instance.GetHeroName(_selectedIndex);

    }
}
