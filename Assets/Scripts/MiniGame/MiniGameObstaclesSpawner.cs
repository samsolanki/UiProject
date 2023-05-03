using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameObstaclesSpawner : MonoBehaviour
{

    [SerializeField] private GameObject[] allObstacles; // ARRAY OF ALL OBSTACLES IN MINIGAMES
    [SerializeField] private float timeBetweenSpawn ; // TIME GAP BETWEEN ONE OBSTACLE SPAWN TO SECOND OBSTACL SPWAN
    [SerializeField] private float minSpawnPos, maxSpawnPos; // MAX AND MIN POSITION IN X AXIS AND Z AXIS OBSTACLE SPAWN
    [SerializeField] private float obstacleMoveSpeed;

    private float currentTimeBetweenSpawn;
    private bool canSpawn;
    private bool checkLevel = false;
    GameObject obstacle;

    // Start is called before the first frame update
    void Start()
    {
        currentTimeBetweenSpawn = timeBetweenSpawn;
    }

    // Update is called once per frame
    void Update()
    {


        SetDifficulityLevel();
        currentTimeBetweenSpawn += Time.deltaTime;

        if(currentTimeBetweenSpawn >= timeBetweenSpawn)
        {
            SpawnObstacle();
            currentTimeBetweenSpawn = 0;
        }
    }

    private void SetDifficulityLevel()
    {
        if(MiniGameManager.instance.CurrentMinigameLevel == 0 && !checkLevel)
        {
            checkLevel = true;
            print("level 0");
        }
        else if(MiniGameManager.instance.CurrentMinigameLevel == 1 && !checkLevel)
        {
            checkLevel = true;
            print("Level 1");
            timeBetweenSpawn -= 1.5f;
            obstacleMoveSpeed += 5;
        }
        else if (MiniGameManager.instance.CurrentMinigameLevel == 2 && !checkLevel)
        {
            checkLevel = true;
            print("Level 2");
            timeBetweenSpawn -= 1f;
            obstacleMoveSpeed += 5;
        }
    }

    private void SpawnObstacle()
    {
        float randomPosX = Random.Range(minSpawnPos, maxSpawnPos);
        float randomPosZ = Random.Range(minSpawnPos, maxSpawnPos);
        
        int randomIndex = Random.Range(0, allObstacles.Length);
        
        obstacle = Instantiate(allObstacles[randomIndex], transform.position + new Vector3(randomPosX , 0 ,randomPosZ), Quaternion.Euler(0,-90,0));

        if(obstacle.GetComponent<MiniGameObstacle>().enemyType == EnemyType.shootingEnemy)
        {
            MiniGameManager.instance.AddEnemyInList(obstacle);
        }

    }

    public bool CheckLevel
    {
        set
        {
            checkLevel = value;
        }
    }

    public float ObstacleMoveSpeed
    {
        get
        {
            return obstacleMoveSpeed;
        }
    }
}
