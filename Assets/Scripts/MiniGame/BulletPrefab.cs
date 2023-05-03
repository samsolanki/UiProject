using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPrefab : MonoBehaviour
{

    [SerializeField] private float bulletSpeed = 10f;

    private Rigidbody body;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {


        transform.position -= transform.forward * 10f * Time.deltaTime;

        /*
                Vector3 player = GameManager.instance.Player.transform.position;
                Vector3 playerPosition = new Vector3(player.x, transform.position.y, player.y);
                Vector3 direction = new Vector3(player.x, player.y + 1.5f, player.z) - transform.position;
                body.velocity = direction * bulletSpeed;*/
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

}
