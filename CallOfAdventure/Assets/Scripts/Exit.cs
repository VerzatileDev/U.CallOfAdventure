using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    //This ends the game
    public void closegame()
    {
        Debug.Log("Exiting Game...");
        Application.Quit();
    }

}