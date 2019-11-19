using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Private and Public variables
    public float movementSpeed;



    private new Animator animation;  // Player  animator.

    private bool Player_Move;  // Bool which's job is to check if the player is moving..
    private Vector3 Move_last;  // Last movement Of Player



    private Rigidbody2D myRigidbody;



    void Start()
    {
		animation = GetComponent<Animator>();
		myRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {


        Player_Move = false;  // Before Running the rest of the script check if player is
        // Moving  if false that means false. Then Continues on if buttons are pressed.




        // Movement of the player
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            myRigidbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * movementSpeed, myRigidbody.velocity.y);

            Player_Move = true; // Checks Movement in horizontal axis
            Move_last = new Vector3(Input.GetAxisRaw("Horizontal"), 0f);  // Gets last movement from horizontal axis

        }
        //Uses inherent unity axis to move the character
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, Input.GetAxisRaw("Vertical") * movementSpeed);

            Player_Move = true;  // Checks Movement in vertical axis
            Move_last = new Vector3(0f, Input.GetAxisRaw("Vertical"));  // Gets last movement from vertical axis
        }

        if (Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f)
        {
            myRigidbody.velocity = new Vector2(0f, myRigidbody.velocity.y);

        }
        if (Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f)
        {

            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, 0f);
        }
      



		animation.SetFloat ("X_velocity", Input.GetAxisRaw ("Horizontal")); // Animation Set from player Input.
		animation.SetFloat ("Y_velocity", Input.GetAxisRaw ("Vertical"));


        animation.SetBool("Player_Move", Player_Move);  
        animation.SetFloat("XMove_last", Move_last.x);
        animation.SetFloat("YMove_last", Move_last.y);

    }



    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Debug.Log("Within Range");

        }
    }
}
