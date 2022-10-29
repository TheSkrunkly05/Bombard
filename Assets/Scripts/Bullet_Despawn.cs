using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Despawn : MonoBehaviour
{
    public GameObject hitEffect;
    public GameObject killEffect;
    public GameObject killEffect2;
    public GameObject killEffect3;
    public GameObject killEffect4;

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (gameObject.tag == "Enemy" || gameObject.tag == "EnemyBomb" ) {

            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            GameObject effect2 = Instantiate(killEffect, transform.position, Quaternion.identity);
            GameObject effect3 = Instantiate(killEffect2, transform.position, Quaternion.identity);
            GameObject effect4 = Instantiate(killEffect3, transform.position, Quaternion.identity);
            GameObject effect5 = Instantiate(killEffect4, transform.position, Quaternion.identity);
            Destroy(effect, 5f);
            Destroy(effect2, 5f);
            Destroy(effect3, 5f);
            Destroy(effect4, 5f);
            Destroy(effect5, 5f);
            Destroy(gameObject);
            Invoke("Destroy", 0f);
        }
    }

    void Update()
    {
        Invoke("Destroy", 3f);
    }

    void Destroy()
    {
        Destroy(gameObject);
    }
}
