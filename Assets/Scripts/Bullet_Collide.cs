using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Collide : MonoBehaviour
{
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
        }

        if (collision.gameObject.tag == "EnemyBomb")
        {
            Debug.Log("bullets collide");
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
