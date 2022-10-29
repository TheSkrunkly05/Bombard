using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Bullet_Collide : MonoBehaviour
{
    public GameObject hitEffect;
    public GameObject killEffect;
    public GameObject killEffect2;
    public GameObject killEffect3;
    public GameObject killEffect4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PlayerBullet")
        {
            Debug.Log("bullets collide");
            Destroy(gameObject); 

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
        }
        else
        {

        }
    }
}
