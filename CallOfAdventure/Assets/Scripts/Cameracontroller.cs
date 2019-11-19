using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontroller : MonoBehaviour
{
    
    //This script makes the camera follow the player
    public float moveSpeed;
    public GameObject followTarget;

    private Vector3 targetPosition;




    // The camera find the player tag and then tries to keep up with it. The moveSpeed allows it to be slightly slower giving it a feeling of movmenet even in identical area (long hallways)
    void Update()
    {
		followTarget = GameObject.FindGameObjectWithTag("Player");
        targetPosition = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed - Time.deltaTime);
    }
}
