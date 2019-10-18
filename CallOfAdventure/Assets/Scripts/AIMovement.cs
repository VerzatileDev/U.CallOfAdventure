using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    
    GameObject player;
    Rigidbody2D rb;
    public float Vision = 3f;
    
    
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //find the player using tags & assign it to a variable
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //push the enemy towards the player



        float distance = Vector3.Distance(player.transform.position, transform.position);
        if (distance <= Vision)

                {
                Vector2 directionOfForce = player.transform.position - transform.position;
                directionOfForce = directionOfForce.normalized;

                rb.AddForce(directionOfForce * 2f);
                rb.velocity = Vector2.ClampMagnitude(rb.velocity, 2f);
                }
        
    }

}




