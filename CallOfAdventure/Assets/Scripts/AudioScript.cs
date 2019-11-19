using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
//This script ties the Volume to a Slider inside a scene

public class AudioScript : MonoBehaviour {


    public AudioMixer mixer;

    
    public void SetVolume (float sliderValue)

    {
        mixer.SetFloat("MasterSound", Mathf.Log10(sliderValue) * 20);
    }
}