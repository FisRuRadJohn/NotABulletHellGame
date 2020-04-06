using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]



public class AIMovement : MonoBehaviour
{
    public float velocidadAI;

    private Rigidbody2D rigidbody2D;
    private Vector2 direction;



    void Start()
    {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = Vector2.right * velocidadAI;
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("LeftB")) 
        {
            rigidbody2D.velocity = Vector2.right * velocidadAI;
        }
        if (other.gameObject.CompareTag("RightB"))
        {
            rigidbody2D.velocity = Vector2.left * velocidadAI;
        }




    }
}
