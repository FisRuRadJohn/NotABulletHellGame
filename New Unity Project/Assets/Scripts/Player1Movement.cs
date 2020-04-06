using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

   

public class Player1Movement : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rigidbody2D;
    private Vector2 direction;


    
    void Start()
    {
        
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        direction = new Vector2(Input.GetAxis("Horizontal"), 0);
    }

    void FixedUpdate()
    {
        //TranslateMovement();
        //AddingForceMovement();
        //VelocityMovement();
        MovePositionMovement();
    }

    void AddingForceMovement()
    {
        rigidbody2D.AddForce(direction * speed);

    }

    void VelocityMovement()
    {
        rigidbody2D.velocity = direction * speed;

    }

    void MovePositionMovement()
    {
        rigidbody2D.MovePosition((Vector2)transform.position + speed * direction * Time.fixedDeltaTime);
    }

    void TranslateMovement()
    {
     
        transform.Translate(direction * speed * Time.fixedDeltaTime);

        /* float x = Input.GetAxis("horizontal");
         float y = 0;

         direction = new Vector2(x, y);*/
    }
}
