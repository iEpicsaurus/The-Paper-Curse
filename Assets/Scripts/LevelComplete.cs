using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This class deals with the scenario when the level has been completed (flower has been reached)
public class LevelComplete : MonoBehaviour {

	// Upon a collision being triggered with the player, move to the next scene (level complete scene)
    private void OnTriggerEnter2D(Collider2D collision) {

    	if(collision.gameObject.CompareTag("Player")) {

			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);

		}

	}

}
