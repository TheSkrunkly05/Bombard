using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Die : MonoBehaviour
{
    [Header("Death Particle")]
    public GameObject ChargeParticle1;

    [Header("Ship")]
    public Transform Ship;
    public GameObject ShipObject;
    public Rigidbody2D Ship_Rigidbody;

    [Header("Screen Shake Variables")]
    public ShakeBehavior Shake;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("PlayerCollides");
        if (collision.gameObject.tag == "EnemyBomb")
        {
            Invoke("Death", 2f);
            Invoke("Dying", 1f);
            Cursor.lockState = CursorLockMode.Locked;
            Ship_Rigidbody.constraints = RigidbodyConstraints2D.FreezePosition;
            Shake.TriggerShake();
        }
    }

    void Death()
    {
        SceneManager.LoadScene("GameOver");
        Destroy(this.gameObject);
        Shake.TriggerShake();
        Cursor.lockState = CursorLockMode.None;
    }

    void Dying()
    {
        GameObject ChargeParticle = Instantiate(ChargeParticle1, Ship.position, Ship.rotation);
        ShipObject.SetActive(false);

    }
}
