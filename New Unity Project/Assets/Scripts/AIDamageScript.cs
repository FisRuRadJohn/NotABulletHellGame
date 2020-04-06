using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIDamageScript : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public EnemyHP healthbar;
    private float deathT = 0.3f;
    public GameObject winPanel;


    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxEnemyHealth(maxHealth);
    }

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlayerBullet"))
        {
            TakeDamage(1);

            if (currentHealth < 1)
            {
                Time.timeScale = deathT ;

                WinPanel();
            }

        }

    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);
    }
    private void WinPanel()
    {
        winPanel.gameObject.SetActive(true);
    }
}

