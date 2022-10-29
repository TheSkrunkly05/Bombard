using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Basic Enemy", menuName = "Basic Enemy")]
public class BasicEnemyScriptableObject : ScriptableObject
{
    [Header("Name")]
    public string name;

    [Header("Revolve Movement")]
    public float RotateSpeed;
    public int Radius;

    [Header("Rotate Movement")]
    public GameObject RotationTarget;
    public float Speed;

    [Header("Shooting Variables")]
    public GameObject ShootingTarget;
    public GameObject Muzzle;
    public GameObject EnemyBullet;
    public int FireRate;
    public float LaunchPower;
}
