using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject PlayerChar1;
    public GameObject PlayerChar2;
    public GameObject PlayerChar3;
    private int choice;
    // Use this for initialization
    void Start()
    {
        if (PlayerPrefs.HasKey("Character") == true)
            choice = PlayerPrefs.GetInt("Character");
            Debug.Log("Player is found");

        if (choice == 1)
            Instantiate(PlayerChar1, new Vector3(-10, 3, -1), Quaternion.identity);
    
        if (choice == 2)
            Instantiate(PlayerChar2, new Vector3(-10, 3, -1), Quaternion.identity);
    
        if (choice == 3)
            Instantiate(PlayerChar3, new Vector3(-10, 3, -1), Quaternion.identity);
    }
        

}


    