using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{

    public void closegame()
    {
        Debug.Log("Exitting Game...");
        Application.Quit();
    }

}