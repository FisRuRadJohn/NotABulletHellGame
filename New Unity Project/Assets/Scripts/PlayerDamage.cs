using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDamage : MonoBehaviour
{
    public int maxHealth1 = 100;
    public int currentHealth1;
    public PlayerHP healthbar1;
    private float deathT1 = 0.3f;
    public GameObject deathPanel;


    void Start()
    {
        currentHealth1 = maxHealth1;
        healthbar1.SetMaxEnemyHealth(maxHealth1);
        Time.timeScale = 1;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("EnemyBullet"))
        {
            TakeDamageP(20);

            if (currentHealth1 < 1)
            {
                Time.timeScale = deathT1;

                DeathPanel();
            }

        }

    }

    void TakeDamageP(int damage1)
    {
        currentHealth1 -= damage1;
        healthbar1.SetHealth(currentHealth1);
    }
    private void DeathPanel()
    {
        deathPanel.gameObject.SetActive(true);
    }
}

