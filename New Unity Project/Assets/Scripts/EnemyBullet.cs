using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public GameObject enemyBullet;

    public float cooldown = 3f;

    private float lastShootTime = 0;

    


    void Update()
    {


        if (Time.time > (lastShootTime + cooldown) || lastShootTime == 0)
        {

            if (Input.GetKey("p") ) // || Input.GetKey("joystick button 0"))
            {
                foreach (Transform child in transform)
                {
                    Instantiate(enemyBullet, child.position, Quaternion.identity);
                }

                lastShootTime = Time.time;

            }

        }

    }
}
