using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class deals with character behaviour on collision with other objects
public class charRespawn : MonoBehaviour {

	public Vector3 respawnPoint;
	private GameObject[] coins;
	public AudioSource PaperTear;
	public AudioSource CoinSound;

	// Start is called before the first frame update
	void Start()
	{

		// Get all game objects tagged with "Coin"
		coins = GameObject.FindGameObjectsWithTag("Coin");

	}

	public void OnCollisionEnter2D(Collision2D collision)
	{

		// If the collision object is an enemy, respawn the player at the last checkpoint
		if (collision.gameObject.tag == "Enemy")
		{

			PaperTear.Play();
			// Re-activate each of the coins
			foreach (GameObject coin in coins)
            {
				coin.SetActive(true);
            }

			// Move the players position to respawn point
			transform.position = respawnPoint;

		}

		// If the collision object is a coin, deactivate the coin
		if (collision.gameObject.tag == "Coin")
		{

			CoinSound.Play();
			collision.gameObject.SetActive(false);

		}

	}

	// If the collision object is a checkpoint, update the players respawn point
	public void OnTriggerEnter2D(Collider2D collision)
	{

		if (collision.gameObject.tag == "Checkpoint")
		{

			respawnPoint = collision.transform.position;

		}

	}
}
