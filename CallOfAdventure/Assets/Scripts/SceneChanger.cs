using UnityEngine.SceneManagement;
using UnityEngine;


public class SceneChanger : MonoBehaviour {

	public Animator animator;

	//private int levelToLoad;

	void update (){
		//if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == FighScene
			//{
	//}

			}


	public void changemenuscene(string scenename)
	{
		Application.LoadLevel(scenename);

	}


	// Fades between Scene/Level changes.

	// Animator For Fader Between levels.
	//FaderOut Is not used, In this but can be used for the Future ones




	//public void FaderOnLevels (int levelIndex)
	//{
		//levelToLoad = levelIndex;
		//animator.SetTrigger ("FaderOut");

	//}



	//public void FaderComplete ()
	//{
	//	SceneManager.LoadScene (levelToLoad);
	}
