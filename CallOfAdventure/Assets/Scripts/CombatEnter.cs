using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CombatEnter : MonoBehaviour
{
    // This script causes the scene to change when player collides with the enemy
    public GameObject player;
    public float Trigger = 1f;

    void FixedUpdate()
    {

        // If the two object touch this will call "Scene is Changing"


		player = GameObject.FindGameObjectWithTag("Player");
        float distance = Vector3.Distance(player.transform.position, transform.position);
        if (distance <= Trigger)

        {
            Debug.Log("Scene is Changing");
            //WIP!!!!!!
        }

    }

}


