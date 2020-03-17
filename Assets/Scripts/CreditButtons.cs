using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CreditButtons : MonoBehaviour {

    // Upon pressing Return to Main Menu, the first scene is loaded (main menu)
	public void ReturnToMain() {

		SceneManager.LoadScene(0);

	}

	// Upon pressing Quit, the application will terminate.
	public void QuitGame() {

		Application.Quit();

	}
}
