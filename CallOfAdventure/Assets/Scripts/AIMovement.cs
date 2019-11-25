
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    //This code moves the enemies towards the player in game
    GameObject player;
    Rigidbody2D rb;
    public float Vision = 3f;

	//private bool Enemy_moving = false ;

	//private new Animator animation; // animator for enemies 
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

		//animation = GetComponent<Animator>();
        
    }


    void FixedUpdate()
    {

        

        //Finds the player
		player = GameObject.FindGameObjectWithTag("Player");
        //Pushes the object towards the player so long as the player gets close
        float distance = Vector3.Distance(player.transform.position, transform.position);
        if (distance <= Vision)
			
		
                {
				//Enemy_moving = true;
			//if directionofForce 
				
				Vector2 directionOfForce = player.transform.position - transform.position;
                directionOfForce = directionOfForce.normalized;

                rb.AddForce(directionOfForce * 2f);
                rb.velocity = Vector2.ClampMagnitude(rb.velocity, 2f);
                }



		        
    }

}




