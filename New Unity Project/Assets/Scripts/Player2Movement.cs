using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  [RequireComponent(typeof(Rigidbody2D))]



public class Player2Movement : MonoBehaviour
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
        direction = new Vector2(Input.GetAxis("Horizontal2"), 0);
    }

    void FixedUpdate()
    {
        
        VelocityMovement();
        
    }

    

    void VelocityMovement()
    {
        rigidbody2D.velocity = direction * speed;

    }

  

}

