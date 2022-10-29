using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource Click;
    public AudioClip click;
    public float volume = 1f;

    //public GameObject MainCamera;
    // Start is called before the first frame update
    void Start()
    {
     //   Click = MainCamera.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void Clicked()
    {
        Debug.Log("Clicked");
        Click.PlayOneShot(click, volume);
    }
}
