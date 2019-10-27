using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class AudioScript : MonoBehaviour {


    public AudioMixer mixer;


    public void SetVolume (float sliderValue)

    {
        mixer.SetFloat("MasterSound", Mathf.Log10(sliderValue) * 20);
    }
}