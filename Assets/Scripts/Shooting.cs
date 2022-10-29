using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [Header("FirePoints")]
    public Transform FirePoint;
    public Transform FirePoint2;
    public Transform FirePoint3;

    [Header("Prefab")]
    public GameObject BulletPrefab;
    public GameObject ChargeCorePrefab;
    public Transform Ship;

    [Header("Particles")]
    public GameObject ChargingEffect1;
    public Transform ChargingEffect1Transform;
    public GameObject MusselFlash;
    public GameObject ChargeParticle;
    public GameObject CoolingParticle;


    [Header("Force")]
    public float BulletForce = 20f;
    public float ChargeForce = 40f;

    [Header("Cooldown")]
    public float FireRate = 10.0f;
    public float NextFire;

    [Header("Screen Shake")]
    public ShakeBehavior Shake;

    [Header("Sounds")]
    public AudioSource BigShoot;
    public AudioSource BigCharge;

    void Update()
    {
   //     ChargingEffect1.transform.position = ChargingEffect1Transform.transform.position;
   //     ChargingEffect1Transform.transform.position = FirePoint2.transform.position;
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        if (Input.GetButtonDown("Fire2") && Time.time > NextFire)
        {
            NextFire = Time.time + FireRate;

            Invoke("Charge", 1.5f);
            GameObject ChargingEffect = Instantiate(ChargingEffect1, Ship.position, Ship.rotation);

            BigCharge.Play();
            Debug.Log("BigCharge play");
        }
    }

    void Shoot()
    {
        GameObject MusselPoint = Instantiate(MusselFlash, FirePoint2.position, FirePoint2.rotation);
        GameObject Bullet = Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);
        Rigidbody2D rb = Bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(FirePoint.up * BulletForce, ForceMode2D.Impulse);
    }

    void Charge()
    {
        Shake.TriggerShake();
        Debug.Log("Charge");
        GameObject CooldownParticle = Instantiate(CoolingParticle, Ship.position, Ship.rotation);
        GameObject ChargePoint = Instantiate(ChargeParticle, FirePoint2.position, FirePoint2.rotation);
        GameObject ChargeCore = Instantiate(ChargeCorePrefab, FirePoint3.position, FirePoint3.rotation);
        Rigidbody2D rb = ChargeCore.GetComponent<Rigidbody2D>();
        rb.AddForce(FirePoint3.up * ChargeForce, ForceMode2D.Impulse);
        BigShoot.Play();
        Debug.Log("BigShoot play");
    }
}
