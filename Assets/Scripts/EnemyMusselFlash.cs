using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMusselFlash : MonoBehaviour
{
    [Header("Particles")]
    public GameObject EnemyMuzzleFlash;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Awake()
    {
        GameObject EnemyEffect = Instantiate(EnemyMuzzleFlash, transform.position, Quaternion.identity);
        Destroy(EnemyEffect, 5f);
    }
}
