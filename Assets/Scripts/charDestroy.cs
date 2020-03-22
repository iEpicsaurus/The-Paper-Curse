using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.UI;

// This class deals with character behaviour on collision with other objects
public class charDestroy : MonoBehaviour {

	public AudioSource PaperTear;
	public AudioSource CoinSound;

	public Text coinsUI;
	private int coinsCollected;

	void Start ()
    {
		// Setting up coin UI
		coinsCollected = 0;
		coinsUI = GameObject.Find("CoinsUI").GetComponent<Text>();
		coinsUI.text = "Coins: " + coinsCollected;
	}

	public async void OnCollisionEnter2D(Collision2D collision) {

		// If the collision object is an enemy, restart the level
		if (collision.gameObject.tag == "Enemy") {

			PaperTear.Play();
			await Task.Delay(200); // Waits .02 seconds to play death sound.
			Application.LoadLevel(Application.loadedLevel);

		}

		// If the collision object is a coin, remove the coin from the screen and play the coin sound.
		if (collision.gameObject.tag == "Coin") {

			CoinSound.Play();
			Destroy(collision.gameObject);

			// Update Coin indicator UI
			coinsCollected++;
			coinsUI.text = "Coins: " + coinsCollected;

		}

	}

}
