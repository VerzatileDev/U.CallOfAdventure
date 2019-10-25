using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Private and Public variables
    public float movementSpeed;

    private Animator animation;

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


        // Movement of the player
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            myRigidbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * movementSpeed, myRigidbody.velocity.y);


        }

        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, Input.GetAxisRaw("Vertical") * movementSpeed);


        }

        if (Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f)
        {
            myRigidbody.velocity = new Vector2(0f, myRigidbody.velocity.y);

        }
        if (Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f)
        {

            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, 0f);
        }
      
		animation.SetFloat ("X_velocity", Input.GetAxisRaw ("Horizontal"));
		animation.SetFloat ("Y_velocity", Input.GetAxisRaw ("Vertical"));
    }
}
