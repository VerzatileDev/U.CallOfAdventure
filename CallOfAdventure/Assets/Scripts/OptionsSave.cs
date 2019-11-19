using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsSave : MonoBehaviour {
    //This script uses player prefs to save the value of Volume
	public Slider slider;

    //Checks for previous save and uses it
	void Start () {
		slider = GetComponent<Slider> ();
		if (PlayerPrefs.HasKey ("Volume") == true)
			slider.value = PlayerPrefs.GetFloat ("Volume");
	}
	

    //Uses the Apply button to save the value for later
	public void SaveVolume()
	{
		float volume = slider.value;
		PlayerPrefs.SetFloat ("Volume", volume);
		PlayerPrefs.Save ();
	}
}
