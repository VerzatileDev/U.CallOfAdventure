using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CombatEnter : MonoBehaviour
{

    public GameObject player;
    public float Trigger = 1f;


    // Use this for initialization
    void Start()
    {
        
        //find the player using tags & assign it to a variable
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //push the enemy towards the player


		player = GameObject.FindGameObjectWithTag("Player");
        float distance = Vector3.Distance(player.transform.position, transform.position);
        if (distance <= Trigger)

        {
            Debug.Log("Scene is Changing");
            
        }

    }

}


