using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum EnemyType
{
    stone,
    shootingEnemy
}

public class MiniGameObstacle : MonoBehaviour
{

    public EnemyType enemyType;

    [Header("Required Component")]
    [SerializeField] private Animator enemyAnim = null;

    [Header("Shooting Enemy bullet")]
    [SerializeField] private Transform enemyBody;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform shootingPoint;
    [SerializeField] private float enemyStopingRange = 20f;
    [SerializeField] private float bulletShootTime = 2f;

    private bool canMove = false;
    private bool canShoot = false;
    [SerializeField] private float currentBulletShootTime;

    // Start is called before the first frame update
    void Start()
    {
        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (canShoot)
        {
            currentBulletShootTime += Time.deltaTime;
            if (currentBulletShootTime >= bulletShootTime)
            {
                GameObject shoot = Instantiate(bulletPrefab, shootingPoint.position, Quaternion.identity);
                shoot.transform.position += transform.forward * 10f * Time.deltaTime;
                currentBulletShootTime = 0;
            }
        }

        if (canMove)
        {
            transform.position -= Vector3.forward * MiniGameManager.instance.ObstacleMoveSpeed * Time.deltaTime;

            if (enemyType == EnemyType.shootingEnemy)
            {
                enemyAnim.SetBool("canShoot", false);

                if(Vector3.Distance(transform.position , GameManager.instance.Player.transform.position) < enemyStopingRange)
                {
                    canShoot = true;
                    canMove = false;
                    enemyAnim.SetBool("canShoot", true);
                    enemyBody.transform.LookAt(GameManager.instance.Player.transform.position);
                }
            }
        }
        
    }


    public void ShootBullet()
    {

    }
}
