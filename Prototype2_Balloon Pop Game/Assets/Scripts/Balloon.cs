using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int clickToPop = 3; //How many clicks before ballon pops
    public float scaleToIncrease = 0.10f; //Scale increased each time the ballon is clicked
    public int scoreToGive; //Score given for the popped balloon
    private ScoreManager scoreManager; //A variable to reference the ScoreManager
    public GameObject popEffect; //Reference Pop Effect Partical System

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    void OnMouseDown() 
    {
        //Reduce clicks by one
        clickToPop -= 1;
        //Increase balloon size
        transform.localScale += Vector3.one * scaleToIncrease;

        if(clickToPop == 0)
        {
            scoreManager.IncreaseScoreText(scoreToGive); //Increase Score
            Instantiate(popEffect, transform.position, transform.rotation); // Instantiate Particle Effect - Pop Effect
            Destroy(gameObject); //Pop Balloon
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
