using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroesManager : MonoBehaviour
{
    public static HeroesManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public HeroData[] all_HeroData;

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

    public string GetHeroDese()
    {
        return null;
    }

    //GETTER FOR STATES




}
