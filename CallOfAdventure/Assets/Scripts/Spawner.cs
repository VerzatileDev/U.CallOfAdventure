using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject PlayerChar1;
    public GameObject PlayerChar2;
    public GameObject PlayerChar3;
	public int a;
	public int b;
	public int c;
    private int choice;
    //This script instantiates a characer depending on a previous choice through player prefs
    

	void Start()
    {
        if (PlayerPrefs.HasKey("Character") == true)
            choice = PlayerPrefs.GetInt("Character");
            Debug.Log("Player is found");

        if (choice == 1)
            Instantiate(PlayerChar1, new Vector3(a, b, c), Quaternion.identity);
    
        if (choice == 2)
            Instantiate(PlayerChar2, new Vector3(a, b, c), Quaternion.identity);
    
        if (choice == 3)
            Instantiate(PlayerChar3, new Vector3(a, b, c), Quaternion.identity);
    }
        

}


    //-10 3 -1