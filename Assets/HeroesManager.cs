using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroesManager : MonoBehaviour
{
    public static HeroesManager Instance;
    [SerializeField] private Transform activeHeroParent;

    public int currentlyActiveHero;

    [SerializeField] private Vector3 v3_HeroPositionOffset;

    private void Awake()
    {
        Instance = this;

        if (!PlayerPrefs.HasKey(PlayerPrefsKey.PLAYERPREFS_HERO_ACTIVE_INDEX))
        {
            SetActiveHero();
        }
        else
        {
            GetActiveHero();
        }
        ActiveCurrentHero(currentlyActiveHero);
    }

    public HeroData[] all_HeroData;


    public void SetActiveHero()
    {
        PlayerPrefs.SetInt(PlayerPrefsKey.PLAYERPREFS_HERO_ACTIVE_INDEX, 0);
        currentlyActiveHero = PlayerPrefs.GetInt(PlayerPrefsKey.PLAYERPREFS_HERO_ACTIVE_INDEX);
        
    }

    public void GetActiveHero()
    {
        currentlyActiveHero = PlayerPrefs.GetInt(PlayerPrefsKey.PLAYERPREFS_HERO_ACTIVE_INDEX);
    }

    public void ActiveCurrentHero(int _heroIndex)
    {
        for(int i =0; i < all_HeroData.Length; i++)
        {
            if(i == _heroIndex)
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
    public float GetHeroDamage(int _heroIndex)
    {
        return all_HeroData[_heroIndex].flt_Damage;
    }

    public float GetHeroFirerate(int _heroIndex)
    {
        return all_HeroData[_heroIndex].flt_FireRate;
    }



}
