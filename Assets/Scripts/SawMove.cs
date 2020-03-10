using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// CREDITS: Code created with the help of a tutorial by Blackthornprod (https://www.youtube.com/watch?v=aRxuKoJH9Y0)
// This class gives functionality to the saws; they will move back and forth on their platform
public class SawMove : MonoBehaviour {

	public float speed;
	public float distance = 2;
	public Transform groundDetection;
	
	private bool currentRight = true;

    // Update is called once per frame
    private void Update() {
 
		transform.Translate(Vector2.right * speed * Time.deltaTime);

		// Projects an invisible ray downwards from the reference position (groundDetection)
		// If there is no collision with the ground, there is still room on the platform
		RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
		if(groundInfo.collider == false) {

			// If currently moving right and saw has reached the edge of platform, turn left
			if(currentRight == true) { 

				transform.eulerAngles = new Vector3(0, -180, 0);
				currentRight = false;

			}

			// If currently moving left and saw has reached the edge of platform, turn right
			else {

				transform.eulerAngles = new Vector3(0, 0, 0);
				currentRight = true;

			}

		}

		// Projects an invisible ray to the right from the reference position (groundDetection)
		// If there is no collision with an object to the right, there is still room on the platform and it has not collided with another object
		RaycastHit2D objectInfoR = Physics2D.Raycast(groundDetection.position, Vector2.right, distance);
		if(objectInfoR.collider == true) {

				// If there is a collision, turn left
				transform.eulerAngles = new Vector3(0, -180, 0);
				currentRight = false;

			}

		// Projects an invisible ray to the left from the reference position (groundDetection)
		// If there is no collision with an object to the left, there is still room on the platform and it has not collided with another object
		RaycastHit2D objectInfoL = Physics2D.Raycast(groundDetection.position, Vector2.left, distance);
		if(objectInfoL.collider == true) {

				// If there is a collision, turn right
				transform.eulerAngles = new Vector3(0, 0, 0);
				currentRight = true;

		}

    }

}
