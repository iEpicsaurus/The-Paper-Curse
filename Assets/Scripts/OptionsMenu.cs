using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

// This class provides functionality to the options menu
public class OptionsMenu : MonoBehaviour {

	public AudioMixer audioMixer;
	public Slider slider;

	void Start() {

		slider.value = PlayerPrefs.GetFloat("MusicVolume", 0.3f);

	}

	// Changes the value to -80 to 0 on a logarithmic scale; conversion is done using Mathf function
	// Saves the value to be used for other scenes; ensures constant volume
	public void setVolume(float newVolume) {

		audioMixer.SetFloat("masterVolume", Mathf.Log10(newVolume) * 20);
		PlayerPrefs.SetFloat("MusicVolume", newVolume);

	}


}