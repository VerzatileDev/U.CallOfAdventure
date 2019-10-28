using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Private and Public variables
    public float movementSpeed;

    private new Animator animation;  // Accessig the animator.

    private bool Player_Move;
    private Vector3 Move_last;

    private Rigidbody2D myRigidbody;



    // Use this for initialization
    void Start()
    {
		animation = GetComponent<Animator>();
		myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        Player_Move = false;  // Before Running the rest of the script check if player is
        // Moving  if false that means false. Then Continues on if buttons are pressed.




        // Movement of the player
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            myRigidbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * movementSpeed, myRigidbody.velocity.y);
            Player_Move = true;
            Move_last = new Vector3(Input.GetAxisRaw("Horizontal"), 0f);

        }

        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, Input.GetAxisRaw("Vertical") * movementSpeed);
            Player_Move = true;
            Move_last = new Vector3(0f, Input.GetAxisRaw("Vertical"));
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
}
