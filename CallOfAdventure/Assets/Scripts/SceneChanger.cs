using UnityEngine.SceneManagement;
using UnityEngine;


public class SceneChanger : MonoBehaviour {

	public Animator animator;




	public void changemenuscene(string scenename)
	{
		Application.LoadLevel(scenename);

	}

}

