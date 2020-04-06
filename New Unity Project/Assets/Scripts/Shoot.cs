using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;

    public float cooldown = 2f;

    private float lastShootTime = 0;

    //private bool modoDisparo = false;

    
    void Update()
    {
        

        if (Time.time > (lastShootTime + cooldown) || lastShootTime == 0 )
        { 

            if (Input.GetKey("space") || Input.GetKey("joystick button 0"))
            {
                foreach (Transform child in transform)
                {
                    Instantiate(bullet, child.position, Quaternion.identity);
                }

                lastShootTime = Time.time;
            
            }

        }

    }
}
