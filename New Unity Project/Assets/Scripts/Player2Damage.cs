using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Damage : MonoBehaviour
{
    public int maxHealth2 = 100;
    public int currentHealth2;
    public Player2HP healthbar2;
    private float deathT2 = 0.3f;
    public GameObject deathPanel2;


    void Start()
    {
        currentHealth2 = maxHealth2;
        healthbar2.SetMaxP2Health(maxHealth2);
        Time.timeScale = 1;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlayerBullet"))
        {
            TakeDamageP2(20);

            if (currentHealth2 < 1)
            {
                Time.timeScale = deathT2;

                DeathPanel2();
            }

        }

    }

    void TakeDamageP2(int damage2)
    {
        currentHealth2 -= damage2;
        healthbar2.SetHealth(currentHealth2);
    }
    private void DeathPanel2()
    {
        deathPanel2.gameObject.SetActive(true);
    }
}
