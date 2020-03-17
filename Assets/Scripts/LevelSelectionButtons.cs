using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectionButtons : MonoBehaviour {

    // Upon pressing Return to Main Menu, the first scene is loaded (main menu)
	public void ReturnToMain() {

		SceneManager.LoadScene(0);

	}

    // Upon pressing Easy, the Easy scene is loaded.
    public void PlayEasy() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

    // Upon pressing Medium, the Medium scene is loaded.
    public void PlayMedium() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
	}
    
    // Upon pressing Hard, the Hard scene is loaded.
    public void PlayHard() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
	}
}
