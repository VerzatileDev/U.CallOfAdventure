using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontroller : MonoBehaviour
{
    // Camera controller Not assigned error>

    public float moveSpeed;
    public GameObject followTarget;

    private Vector3 targetPosition;




    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
		followTarget = GameObject.FindGameObjectWithTag("Player");
        targetPosition = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed - Time.deltaTime);
    }
}
