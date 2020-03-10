using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class deals with character behaviour on collision with other objects
public class charDestroy : MonoBehaviour {

	public void OnCollisionEnter2D(Collision2D collision) {

		// If the collision object is an enemy, restart the level
		if (collision.gameObject.tag == "Enemy") {

			Application.LoadLevel(Application.loadedLevel);

		}

		// If the collision object is a coin, remove the coin from the screen
		if (collision.gameObject.tag == "Coin") {

			Destroy(collision.gameObject);

		}		

	}

}
