using UnityEngine;
using System.Collections;

// CREDITS: This code was created with the help of a tutorial by Studica News https://www.youtube.com/watch?v=iSxifRKQKAA
// This class deals with the keyboard keys to move the player.

public class GameManager : MonoBehaviour
{

	public static GameManager GM;

	// key codes for our character's movements
	public KeyCode jump { get; set; }
	public KeyCode left { get; set; }
	public KeyCode right { get; set; }



	void Awake()
	{
		if (GM == null)
		{
			DontDestroyOnLoad(gameObject);
			GM = this;
		}
		else if (GM != this)
		{
			Destroy(gameObject);
		}

		// a basic buttons' control system before user changes any keys
		jump = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("jumpKey", "Space"));
		left = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("leftKey", "A"));
		right = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("rightKey", "D"));

	}

	void Start()
	{

	}

	void Update()
	{

	}
}
