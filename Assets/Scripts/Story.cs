using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This class provides functionality to the story scene
public class Story : MonoBehaviour {

	// Upon clicking the Continue button, continue to next scene (first level of the game)
	public void Continue() {

		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

	}

}
