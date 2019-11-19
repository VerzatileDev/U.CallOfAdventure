using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
//This ties the mixer to the slider
public class SettingMenu : MonoBehaviour {

    public AudioMixer audioMixer;

	public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
}
