using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Add scene management
using TMPro; //Add the TMPRo namespace (UI)

public class PlayerController2D : MonoBehaviour
{
    //Value Types
    [Header("Player Settings")]
    public float moveSpeed; //How fast the player moves side to side
    public float jumpForce; //How high the player jumps
    public bool isGrounded; //Is the player grounded true or false
    public int bottomBound = -4; //Store bottom boundry value
    [Header("Score")]
    public int score; //Store the scores value

    //Reference Types
    public Rigidbody2D rig; //Rigidbody reference
    public TextMeshProUGUI scoreText; //Text UI reference

    public void AddScore (int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score;
    }

    void FixedUpdate () 
    {
        //Gather Inputs
        float moveInput = Input.GetAxisRaw("Horizontal");
        //Make the player move side to side
        rig.linearVelocity = new Vector2(moveInput * moveSpeed, rig.linearVelocity.y);
    }

    void Update ()
    {
        //If we press the jump button and we are grounded, then jump.
        if(Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            isGrounded = false;
            rig.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); //Makes the player jump with all of the force applied
        }
        if(transform.position.y < bottomBound)
        {
            GameOver();
        }
    }

    void OnCollisionEnter2D (Collision2D collision)
    {
        //If player is touching the ground set isGrounded true
        if(collision.GetContact(0).normal == Vector2.up)
        {
            isGrounded = true;
        }
    }

    //Called when hit by an Enemy or when we fall of the level
    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
