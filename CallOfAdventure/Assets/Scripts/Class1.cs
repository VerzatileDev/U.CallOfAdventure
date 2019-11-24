using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public void changemenuscene(string scenename)
    {
        Application.LoadLevel(scenename);

    }

    public int health = 40;

}
