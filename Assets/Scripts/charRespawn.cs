using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// This class deals with character behaviour on collision with other objects
public class charRespawn : MonoBehaviour {

	public Vector3 respawnPoint;
	private List<GameObject> coins = new List<GameObject>();	// A list of coins collected. Is reset on death/reaching a checkpoint
	public AudioSource PaperTear;
	public AudioSource CoinSound;
	public Text coinsUI;
	private int coinsCollected;

	// Start is called before the first frame update
	void Start()
	{

		// Setting up coin UI
		coinsCollected = 0;
		coinsUI = GameObject.Find("CoinsUI").GetComponent<Text>();
		coinsUI.text = "Coins: " + coinsCollected;

		// Setting up respawn point
		respawnPoint = transform.position;

	}

	public void OnCollisionEnter2D(Collision2D collision)
	{

		// If the collision object is an enemy, respawn the player at the last checkpoint
		if (collision.gameObject.tag == "Enemy")
		{

			PaperTear.Play();

			// Re-activate coins and update counter
			foreach (GameObject coin in coins)
            {
				coin.SetActive(true);
				coinsCollected--;
			}

			// Move the player to respawn point
			transform.position = respawnPoint;

			// Clear the list of coins
			coins.Clear();

		}

		// If the collision object is a coin, deactivate the coin and add it to the coin list
		if (collision.gameObject.tag == "Coin")
		{

			CoinSound.Play();

			// Add the coin to the coins list, deactivate the coin, and increment the number of coins collected
			coins.Add(collision.gameObject);
			collision.gameObject.SetActive(false);
			coinsCollected++;

		}
		
		// Update Coin indicator UI
		coinsUI.text = "Coins: " + coinsCollected;

	}

	// If the collision object is a checkpoint, update the players respawn point
	public void OnTriggerEnter2D(Collider2D collision)
	{

		if (collision.gameObject.tag == "Checkpoint")
		{

			// Update the respawn point and clear the coin list
			respawnPoint = collision.transform.position;
			coins.Clear();

		}

	}
}
