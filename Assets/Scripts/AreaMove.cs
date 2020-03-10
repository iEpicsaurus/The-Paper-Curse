using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class deals with the camera movement for when a new area is entered
// NOTE: currently not in use as it is no longer applicable
public class AreaMove : MonoBehaviour {

	public GameObject vCamera;

	private void OnTriggerEnterArea(Collider2D other) {

		if(other.CompareTag("Player") && !other.isTrigger) {

			vCamera.SetActive(true);

		}

	}

	private void OnTriggerExitArea(Collider2D other) {

		if(other.CompareTag("Player") && !other.isTrigger) {

			vCamera.SetActive(false);

		}

	}

}
