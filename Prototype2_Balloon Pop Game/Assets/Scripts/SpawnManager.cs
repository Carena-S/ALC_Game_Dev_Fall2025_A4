using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] balloonPrefabs; //Array to store the ballon gameobject
    public float startDelay = 0.5f;
    public float spawnInterval = 1.5f;
    public float xRange = 10.0f;


    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon", startDelay, spawnInterval); //Continuously spawn balloons on the x-axis with a start delay and interval delay
    }
    void SpawnRandomBalloon()
    {
        //Get a random position on the X-Axis
        Vector3 spawnPos = new Vector3(Random.Range(-xRange, +xRange), 0, 0);
        //Pick a random balloon from the balloon array
        int balloonIndex = Random.Range(0, balloonPrefabs.Length);
        //Spawn random balloon at the spawn point
        Instantiate(balloonPrefabs[balloonIndex], spawnPos, balloonPrefabs[balloonIndex].transform.rotation);
    }
}

