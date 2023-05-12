using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameObstaclesSpawner : MonoBehaviour
{

    [SerializeField] private GameObject[] allObstacles; // ARRAY OF ALL OBSTACLES IN MINIGAMES
    [SerializeField] private GameObject shootingEnemyPrefab;
    [SerializeField] private bool canShootingEnemySpawn = false;
    [SerializeField] private float timeBetweenSpawnObstacle ; // TIME GAP BETWEEN ONE OBSTACLE SPAWN TO SECOND OBSTACL SPWAN
    [SerializeField] private float timeBetweenSpawnEnemy ; // TIME GAP BETWEEN ONE OBSTACLE SPAWN TO SECOND OBSTACL SPWAN
    [SerializeField] private float minSpawnPos, maxSpawnPos; // MAX AND MIN POSITION IN X AXIS AND Z AXIS OBSTACLE SPAWN
    [SerializeField] private float obstacleMoveSpeed;

    private float currentTimeBetweenSpawnObstacle;
    private float currentTimeBetweenSpawnEnemy;
    private bool canSpawn;
    private bool checkLevel = false;
    GameObject obstacle;
    GameObject shootingEnemy;

    // Start is called before the first frame update
    void Start()
    {
        currentTimeBetweenSpawnObstacle = timeBetweenSpawnObstacle;
        currentTimeBetweenSpawnEnemy = timeBetweenSpawnEnemy;
    }

    // Update is called once per frame
    void Update()
    {

        if (MiniGameManager.instance.IsMiniGameStart)
        {
            SetDifficulityLevel();
            currentTimeBetweenSpawnObstacle += Time.deltaTime;

            if (currentTimeBetweenSpawnObstacle >= timeBetweenSpawnObstacle)
            {
                SpawnObstacle();
                currentTimeBetweenSpawnObstacle = 0;
            }

            currentTimeBetweenSpawnEnemy += Time.deltaTime;

            if (currentTimeBetweenSpawnEnemy >= timeBetweenSpawnEnemy)
            {
                SpawnEnemy();
                currentTimeBetweenSpawnEnemy = 0;
            }
        }

    }

    private void SetDifficulityLevel()
    {
        if(MiniGameManager.instance.CurrentMinigameLevel == 0 && !checkLevel)
        {
            checkLevel = true;
        }
        else if(MiniGameManager.instance.CurrentMinigameLevel == 1 && !checkLevel)
        {
            checkLevel = true;
            timeBetweenSpawnObstacle -= 1.5f;
            obstacleMoveSpeed += 5;
        }
        else if (MiniGameManager.instance.CurrentMinigameLevel == 2 && !checkLevel)
        {
            checkLevel = true;
            timeBetweenSpawnObstacle -= 1f;
            obstacleMoveSpeed += 5;
        }
    }

    private void SpawnObstacle()
    {
        float randomPosX = Random.Range(minSpawnPos, maxSpawnPos);
        float randomPosZ = Random.Range(minSpawnPos, maxSpawnPos);
        
        int randomIndex = Random.Range(0, allObstacles.Length);
        
        obstacle = Instantiate(allObstacles[randomIndex], transform.position + new Vector3(randomPosX , 0 ,randomPosZ), Quaternion.Euler(0,-90,0));
    }

    private void SpawnEnemy()
    {
        float randomPosX = Random.Range(minSpawnPos, maxSpawnPos);
        float randomPosZ = Random.Range(minSpawnPos, maxSpawnPos);

        if (!canShootingEnemySpawn)
        {
            shootingEnemy = Instantiate(shootingEnemyPrefab, transform.position + new Vector3(randomPosX, 0, randomPosZ), Quaternion.Euler(0, -90, 0));
            canShootingEnemySpawn = true;
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


    public bool CanShootingEnemySpawn
    {
        get
        {
            return canShootingEnemySpawn;
        }
        set
        {
            canShootingEnemySpawn = value;
        }
    }

    public GameObject ShootingEnemy
    {
        get
        {
            return shootingEnemy;
        }
    }
}
