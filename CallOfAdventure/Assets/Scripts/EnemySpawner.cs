using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject Goblin;
    public GameObject Ogre;
    private int type;


    // Use this for initialization
    void Start () {

        if (PlayerPrefs.HasKey("Enemy") == true)
            type = PlayerPrefs.GetInt("Enemy");
        Debug.Log("Enemy is found");

        if (type == 1)
            Instantiate(Goblin, new Vector3(-3, -1, -1), Quaternion.identity);

        if (type == 2)
            Instantiate(Ogre, new Vector3(-3, -1, -1), Quaternion.identity);

        else
            Debug.Log("No enemy");
    }

}
