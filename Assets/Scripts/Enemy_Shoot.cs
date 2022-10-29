using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Shoot : MonoBehaviour
{
    [Header("Scriptable Object")]
    public BasicEnemyScriptableObject enemy;

    [Header("Transform")]
    public Transform target; //where we want to shoot(player? mouse?)
    public Transform weaponMuzzle; //The empty game object which will be our weapon muzzle to shoot from

    [Header("Game Objects")]
    public GameObject bullet; //Your set-up prefab

    [Header("Floats")]
    public float fireRate; //Fire every 3 seconds
    public float shootingPower; //force of projection


    private float shootingTime; //local to store last time we shot so we can make sure its done every 3s

    public void Awake()
    {
        fireRate = enemy.FireRate;
        shootingPower = enemy.LaunchPower;
        GameObject bullet = enemy.EnemyBullet;
    }

    private void Update()
    {
        Invoke("Fire", 1f);
    }

    private void Fire()
    {
        if (Time.time > shootingTime)
        {
            shootingTime = Time.time + fireRate / 1000; //how fast the shoot
            Vector2 myPos = new Vector2(weaponMuzzle.position.x, weaponMuzzle.position.y); //where bullet comes from
            GameObject projectile = Instantiate(bullet, myPos, Quaternion.identity); //make bullet
            Vector2 direction = myPos - (Vector2)target.position; //get angle to shoot
            projectile.GetComponent<Rigidbody2D>().velocity = -direction * shootingPower; //shoot
        }
    }
}
