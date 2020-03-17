using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

<<<<<<< Updated upstream
public class LevelSelectionButtons : MonoBehaviour
{
=======
public class LevelSelectionButtons : MonoBehaviour {

>>>>>>> Stashed changes
    // Upon pressing Return to Main Menu, the first scene is loaded (main menu)
	public void ReturnToMain() {

		SceneManager.LoadScene(0);

	}

<<<<<<< Updated upstream
    // Upon pressing Easy, the easy scene is loaded.
    public void PlayBeginner() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

    // Upon pressing Medium, the medium scene is loaded.
    public void PlayMedium() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
	}

    // Upon pressing Hard, the hard scene is loaded.
=======
    // Upon pressing Easy, the Easy scene is loaded.
    public void PlayEasy() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

    // Upon pressing Medium, the Medium scene is loaded.
    public void PlayMedium() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
	}
    
    // Upon pressing Hard, the Hard scene is loaded.
>>>>>>> Stashed changes
    public void PlayHard() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
	}
}
