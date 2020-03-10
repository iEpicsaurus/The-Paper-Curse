using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This class provides functionality for the main menu of the game
public class MainMenu : MonoBehaviour {

	// Upon pressing Play, the next scene will play (the introduction to the story)
	public void PlayGame() {

		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

	}

	// Upon pressing Quit, the application will terminate.
	public void QuitGame() {

		Application.Quit();

	}

}
