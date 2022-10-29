using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeBehavior : MonoBehaviour
{
    private Transform transform;

    private float shakeDuration = 0f;

    private float shakeMagnitude = 1.0f;

    private float dampingSpeed = 1.5f;

    public Vector3 initalPosition;
    // Start is called before the first frame update
    void Awake()
    {
        if (transform == null)
        {
            transform = GetComponent(typeof(Transform)) as Transform;
        }
    }

    // Update is called once per frame
    void OnEnable()
    {
        initalPosition = transform.localPosition;
    }

    void Update()
    {
        if (shakeDuration > 0)
        {
            transform.localPosition = initalPosition + Random.insideUnitSphere * shakeMagnitude;
            shakeDuration -= Time.deltaTime * dampingSpeed;
        }
        else
        {
            shakeDuration = 0f;
            transform.localPosition = initalPosition;
        }
    }

    public void TriggerShake()
    {
        shakeDuration = .5f;
    }
}
