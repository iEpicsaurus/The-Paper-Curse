using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public static bool gamePaused = false;

    public GameObject pauseUI;
    public GameObject optionsUI;

    // Start is called before the first frame update
    void Start()
    {

        // Setting up pause UI
        pauseUI = GameObject.Find("PauseUI");
        pauseUI.SetActive(false);
        optionsUI = GameObject.Find("OptionsMenu");
        optionsUI.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        // Check if the user is pressing escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // If the game is already paused, resume the game
            if (gamePaused)
            {
                Resume();
            }
            // If the game is not already paused, pause it
            else
            {
                Pause();
            }

        }

    }

    // Resume the game - hide pause menu, set timescale
    public void Resume()
    {
        pauseUI.SetActive(false);
        optionsUI.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
    }

    // Pause the game - display pause menu, set timescale
    void Pause()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        gamePaused = true;
    }

    // Upon pressing Return to Main Menu, the first scene is loaded (main menu)
    public void ReturnToMain()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene(0);

    }

    // Upon pressing Quit, the application will terminate.
	public void QuitGame() {

		Application.Quit();

	}


}