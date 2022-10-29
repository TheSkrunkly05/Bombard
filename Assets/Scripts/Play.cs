using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public GameObject Ship;
    // Update is called once per frame

    public void ChangeScene1()
    {
        StartCoroutine(Wait());
    }

    public void ChangeScene2()
    {
        SceneManager.LoadScene("Level 1");
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        ChangeScene2();
    }

    public void TipsScene1()
    {
        StartCoroutine(WaitTips());
    }

    public void TipScene2()
    {
        SceneManager.LoadScene("Tips Scene");
    }

    IEnumerator WaitTips()
    {
        yield return new WaitForSeconds(1);
        TipScene2();
    }

    public void Replay()
    {
        SceneManager.LoadScene("Title Screen");
    }

    public void Start()
    {
        Ship.SetActive(true);
    }
}
