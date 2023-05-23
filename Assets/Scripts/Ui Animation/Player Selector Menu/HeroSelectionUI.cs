using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HeroSelectionUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI txt_HeroName;
    [SerializeField] private GameObject[] allHeros;

    public void OnClickSelectePlayer(int _selectionIndex)
    {
        txt_HeroName.text = HeroesManager.Instance.GetHeroName(_selectionIndex);
        if (_selectionIndex == HeroesManager.Instance.GetHeroId(_selectionIndex))
        {
            allHeros[_selectionIndex].SetActive(true);
        }
        else
        {
            for(int i =0; i < allHeros.Length; i++)
            {
                allHeros[i].SetActive(false);
            }
        }
    }

    private void SetSelectedHeroData(int _selectedIndex)
    {
        txt_HeroName.text = HeroesManager.Instance.GetHeroName(_selectedIndex);

    }
}
