using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// CREDITS: This code was created with the help of a tutorial by Blackthornprod (https://www.youtube.com/watch?v=j111eKN8sJw)
// This class deals with the character movement.
public class CharacterController2D : MonoBehaviour
{

    private Rigidbody2D rb;
    private float input;
    private bool isGrounded;
    private float jumpTimeCounter;
    private bool currentlyJumping;

    public float speed;
    public float jumpForce;
    public Transform footPosition;
    public float checkRadius;
    public LayerMask whatIsGround;
    public float jumpTime;
    public AudioSource Jump;

    // Start is called before the first frame update
    private void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    // Deals with horizontal movement input
    private void FixedUpdate()
    {

        // Obtains the input (NB: returns -1 if left arrow key is pressed and 1 if right arrow key is pressed)
        // Moves character in the direction per the input
        if (Input.GetKey(GameManager.GM.left))
            transform.position += Vector3.left / 5;
        if (Input.GetKey(GameManager.GM.right))
            transform.position += Vector3.right / 5;
        //  input = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(input * speed, rb.velocity.y);


    }

    // Update is called once per frame
    private void Update()
    {

        // Only returns true if a circle (footPosition) around the feet collides with ground - meaning the character is on the ground and can jump
        isGrounded = Physics2D.OverlapCircle(footPosition.position, checkRadius, whatIsGround);

        // Jumps if currently on an object considered being ground and if Space is pressed
        if (isGrounded == true && Input.GetKeyDown(GameManager.GM.jump))
        {

            Jump.Play();
            currentlyJumping = true;
            jumpTimeCounter = jumpTime;

            rb.velocity = Vector2.up * jumpForce;

        }

        // Deals with when space is held for a longer jump; limits the length of the jump via jumpTimeCounter
        if (Input.GetKey(GameManager.GM.jump) && currentlyJumping == true)
        {

            if (jumpTimeCounter > 0)
            {

                rb.velocity = Vector2.up * jumpForce;
                jumpTimeCounter = jumpTimeCounter - Time.deltaTime;

            }

            else
            {

                currentlyJumping = false;

            }


        }


        if (Input.GetKeyUp(KeyCode.Space))
        {

            currentlyJumping = false;

        }

    }

}
