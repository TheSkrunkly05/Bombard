using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [Header("ScriptableObject")]
    public BasicEnemyScriptableObject enemy;

    [Header("Floats")]
    public float RotateSpeed;
    private float _angle;
    public float Radius;

    [Header("Vector2")]
    private Vector2 _centre;

    private void Awake()
    {
        Radius = enemy.Radius;
        RotateSpeed = enemy.RotateSpeed;
    }

    private void Start()
    {
        _centre = transform.position;
    }

    private void Update()
    {

        _angle += RotateSpeed * Time.deltaTime;

        var offset = new Vector2(Mathf.Sin(_angle), Mathf.Cos(_angle)) * Radius;
        transform.position = _centre + offset;
    }
}
