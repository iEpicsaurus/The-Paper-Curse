using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This class provides functionality for the ending scene of the game when the level is completed
public class Menu : MonoBehaviour {

	// Upon pressing Return to Main Menu, the first scene is loaded (main menu)
	public void ReturnToMain() {

		SceneManager.LoadScene(0);

	}

	// Upon pressing Quit, the application will terminate.
	public void QuitGame() {

		Application.Quit();

	}

}