using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class P2Bullet : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;

    public float velocidad = 10;
    public float t = 2.0F;
    //private int enemyHealth = 30;

    void Start()
    {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = Vector2.down * velocidad;   //vector2.up -> (0,1)
                                                         //vector2.down -> (0,-1)
                                                         //vector2.right -> (1,0)
                                                         //vector2.left -> (-1,0)

        Destroy(gameObject, t);
    }



}