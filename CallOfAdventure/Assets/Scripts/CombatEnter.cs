using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CombatEnter : MonoBehaviour
{

    GameObject player;
    Rigidbody2D rb;
    public float Trigger = 1f;


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
        if (distance <= Trigger)

        {
            Debug.Log("Scene is Changing");

        }

    }

}


