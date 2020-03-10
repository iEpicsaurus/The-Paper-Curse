using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class deals with any objects that will have a falling behaviour
public class FallingObject : MonoBehaviour {
    
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start() {

    	rb = GetComponent<Rigidbody2D>();
        
    }

    // Upon being triggered by a collision with the Player object, cause the game object to fall.
    private void OnTriggerEnter2D(Collider2D collision) {

    	if(collision.gameObject.CompareTag("Player")) {

    		rb.isKinematic = false;

    	}

    }
}
