using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_SHOOT2 : MonoBehaviour
{
    public float speed = 20f;

    public int damage = 40;

    public GameObject impactEffect;

    private Vector3 target;

    private Transform player;

    private Vector3 bulletTrans;

    private Rigidbody2D rb;



    // Use this for initialization

    void Start()

    {

        player = GameObject.FindGameObjectWithTag("Player").transform;

        bulletTrans = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        rb = GetComponent<Rigidbody2D>();

        target = new Vector3(player.position.x, player.position.y, player.position.z);



    }



   // void OnTriggerEnter2D(Collider2D hitInfo)

   // {

      //  PlayerStats playerhit = hitInfo.GetComponent<PlayerStats>();

      //  if (playerhit != null)

    //    {

     //       playerhit.TakeDamage(damage);

     //       DestoryBullet();

    //    }

   // }



    private void FixedUpdate()

    {

        rb.velocity = (target - bulletTrans).normalized * speed;



    }

    void DestoryBullet()

    {

        Instantiate(impactEffect, transform.position, transform.rotation);

        Destroy(gameObject);

    }
}
