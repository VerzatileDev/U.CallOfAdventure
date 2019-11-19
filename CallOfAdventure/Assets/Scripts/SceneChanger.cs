using UnityEngine.SceneManagement;
using UnityEngine;


public class SceneChanger : MonoBehaviour {
    //This script changes the scenes, it depends on their name in the unity
	public Animator animator;




	public void changemenuscene(string scenename)
	{
		Application.LoadLevel(scenename);

	}

}

