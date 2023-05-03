using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameManager : MonoBehaviour
{
    public static MiniGameManager instance;




    [SerializeField] private bool isMiniGameStart = false;
    [SerializeField] private int currentMinigameLevel = 0;
    [SerializeField] private int nextLevelIndex = 20;
    [SerializeField] private float minigameRunningTime = 0;
    [SerializeField] private List<GameObject> list_ActiveEnemy;

    [SerializeField] private MiniGameObstaclesSpawner obstacleSpawner;
    private void Awake()
    {
        if (instance != this || instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        minigameRunningTime += Time.deltaTime;

        if(minigameRunningTime >= nextLevelIndex)
        {
            nextLevelIndex += 20;
            currentMinigameLevel++;
            obstacleSpawner.CheckLevel = false; 
        }
    }


    public int CurrentMinigameLevel
    {
        get
        {
            return currentMinigameLevel;
        }
    }


    public float ObstacleMoveSpeed
    {
        get
        {
            return obstacleSpawner.ObstacleMoveSpeed;
        }
    }

    public void  AddEnemyInList(GameObject _Currentenemy)
    {
        list_ActiveEnemy.Add(_Currentenemy);
    }
    public void RemoveEnemyInList(GameObject _Currentenemy)
    {
        list_ActiveEnemy.Remove(_Currentenemy);
    }
    public  List<GameObject > GetListOfEnemy()
    {
        return list_ActiveEnemy;
    } 
}
