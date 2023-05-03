using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private float bulletShootTime = 2f;
    [SerializeField] private GameObject player;

    [SerializeField]private Transform target;
    private float flt_MinDistnce =0;

    private float currentBulletShootTime;
    private bool canShoot = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FindTarget();
        
    }

    private void FindTarget()
    {
        for (int i = 0; i < MiniGameManager.instance.GetListOfEnemy().Count; i++)
        {
           
                float flt_CurrentDistance = Mathf.Abs(Vector3.Distance(transform.position, MiniGameManager.instance
                    .GetListOfEnemy()[i].transform.position));
            if (target == null)
            {
                flt_MinDistnce = flt_CurrentDistance;
                target = MiniGameManager.instance.GetListOfEnemy()[i].transform;
            }
            else if (flt_CurrentDistance<flt_MinDistnce)
            {
                flt_MinDistnce = flt_CurrentDistance;
                target = MiniGameManager.instance.GetListOfEnemy()[i].transform;
            }
            
        }

        if (target != null)
        {
            player.transform.LookAt(target.position);
            FireBullet();
        }
    }

    private void FireBullet()
    {
        currentBulletShootTime += Time.deltaTime;
        if (currentBulletShootTime >= bulletShootTime)
        {
            currentBulletShootTime = 0;
            ShootBullet();
        }
    }

    private void ShootBullet()
    {
       GameObject bullet =  Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);

        Vector3 direction = -player.transform.position + target.position;
        bullet.GetComponent<PlayerBullet>().SetDirection(direction + new Vector3(0,1.5f,0));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ShootingEnemy"))
        {
            Destroy(gameObject);
        }
    }

}
