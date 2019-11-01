using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsSave : MonoBehaviour {

	public Slider slider;

	// Use this for initialization
	void Start () {
		slider = GetComponent<Slider> ();
		if (PlayerPrefs.HasKey ("Volume") == true)
			slider.value = PlayerPrefs.GetFloat ("Volume");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SaveVolume()
	{
		float volume = slider.value;
		PlayerPrefs.SetFloat ("Volume", volume);
		PlayerPrefs.Save ();
	}
}
