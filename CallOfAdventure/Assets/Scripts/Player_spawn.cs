using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_spawn : MonoBehaviour
{

    //This script saves which character you chose for later instantiation
    public void ChoosePlayer(int character)
    {
        int choice = character;
        PlayerPrefs.SetInt("Character", choice);
        PlayerPrefs.Save();
    }

}