using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Rotate : MonoBehaviour
{
    [Header("ScriptableObject")]
    public BasicEnemyScriptableObject enemy;

    [Header("Target and Speed")]
    public Transform target;
    public float speed;

    public void Awake()
    {
        //Where Scriptable Objects are being set
        speed = enemy.Speed;
        GameObject target = enemy.RotationTarget;
    }

    private void Update()
    {
        MoveTowardsTarget();
        RotateTowardsTarget();
        if (Vector2.Distance(transform.position, target.position) > 1f)
        {
            MoveTowardsTarget();
            RotateTowardsTarget();
        }
    }

    private void MoveTowardsTarget()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    private void RotateTowardsTarget()
    {
        var offset = -90f;
        Vector2 direction = target.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(Vector3.forward * (angle + offset));
    }
}
