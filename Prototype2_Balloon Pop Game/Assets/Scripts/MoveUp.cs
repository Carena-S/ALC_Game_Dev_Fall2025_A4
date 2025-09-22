using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveUp : MonoBehaviour
{
    public float speed;
    public float upperBound = 5f; // Set an upper bound for balloons to pass and for penalities to be applied.
    public ScoreManager scoreManager; // Refernecing the Score Manager
    public Balloon balloon; // Reference the balloon script to get the score

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        balloon = GetComponent<Balloon>();
    }
    void Update()
    {
        //Move the ballon up on the y axis at a set rate of speed
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        if(transform.position.y >= upperBound)
        {
            scoreManager.DecreaseScoreText(balloon.scoreToGive); //Reduce score for allowing the balloon to leave the screen. 
            Destroy(gameObject); //Pop the balloon after it leaves the screen
        }
    }
}

