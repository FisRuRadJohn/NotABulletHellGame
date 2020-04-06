using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Shoot : MonoBehaviour
{
    public GameObject enemyBullet;

    public float cooldown = 3f;

    private float lastShootTime = 0;

    private bool modoDisparo = false;

    private void Start()
    {
        InvokeRepeating("IA_Shoot", 1f, 0.5f);
    }
    void IA_Shoot()
    {
        foreach (Transform child in transform)
        {
            Instantiate(enemyBullet, child.position, Quaternion.identity);
        }
    }
}