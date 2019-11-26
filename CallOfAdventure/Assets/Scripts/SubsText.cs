using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubsText : MonoBehaviour {

	public GameObject textbox;


	void Start () {
		StartCoroutine (TheSequence ());
	}
	IEnumerator TheSequence(){
		yield return new WaitForSeconds (1);
		textbox.GetComponent<Text> ().text = "Welcome To Call Of Adventure";
		
		yield return new WaitForSeconds (2);
			textbox.GetComponent<Text>().text = "";
		yield return new WaitForSeconds (1);
		textbox.GetComponent<Text> ().text = "Hope you Enjoy The Alpha stage of the Game";
		yield return new WaitForSeconds (2);
		textbox.GetComponent<Text>().text = "";
	}

}
