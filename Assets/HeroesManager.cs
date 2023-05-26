using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroesManager : MonoBehaviour
{
    public static HeroesManager Instance;
    [SerializeField] private Transform activeHeroParent;

    public int currentlyActiveHero; // currentActiveSelectedHero

    [SerializeField] private Vector3 v3_HeroPositionOffset;
    public HeroData[] all_HeroData;
    public GameObject[] all_HerosModels;


    private void Awake()
    {
        Instance = this;


        ActiveCurrentHero(currentlyActiveHero);
    }



    public void SetActiveHero()
    {

    }

    public void GetActiveHero()
    {

    }




    public void ActiveCurrentHero(int _heroIndex)
    {
        for (int i = 0; i < all_HeroData.Length; i++)
        {
            if (i == _heroIndex)
            {
                all_HeroData[_heroIndex].gameObject.SetActive(true);
            }
            else
            {
                all_HeroData[i].gameObject.SetActive(false);
            }

        }
    }


    // GETTER FOR PROFILE

    public int GetHeroId(int _heroIndex)
    {
        return all_HeroData[_heroIndex].heroID;
    }

    public int GetHeroLevel(int _heroIndex)
    {
        return all_HeroData[_heroIndex].currentLevel;
    }

    public string GetHeroName(int _heroIndex)
    {
        return all_HeroData[_heroIndex].str_HeroName;
    }


    //GETTER FOR STATES

    public float GetHeroHealth(int _heroIndex)
    {
        return all_HeroData[_heroIndex].flt_MaxHealth;
    }

    public void SetHeroHealth(int _heroIndex, float _value)
    {
        all_HeroData[_heroIndex].flt_MaxHealth += _value;
    }

    public void DeceraceHeroHealth(int _heroIndex, float _value)
    {
        all_HeroData[_heroIndex].flt_MaxHealth -= _value;
    }

    public float GetHeroDamage(int _heroIndex)
    {
        return all_HeroData[_heroIndex].flt_Damage;
    }

    public void DeceraceHeroDamage(int _heroIndex, float _value)
    {
        all_HeroData[_heroIndex].flt_Damage -= _value;
    }

    public void SetHeroDamage(int _heroIndex, float _value)
    {
        all_HeroData[_heroIndex].flt_Damage += _value;
    }

    public void DeceraceHeroFirerate(int _heroIndex, float _value)
    {
        all_HeroData[_heroIndex].flt_FireRate -= _value;
    }

    public float GetHeroFirerate(int _heroIndex)
    {
        return all_HeroData[_heroIndex].flt_FireRate;
    }

    public void SetHeroFirerate(int _heroIndex, float _value)
    {
        all_HeroData[_heroIndex].flt_FireRate += _value;
    }
}
