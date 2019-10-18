using System.Collections.Generic;
using UnityEngine;


public class BacktoMenu : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Application.LoadLevel("Savefiles");
        }
    }
}