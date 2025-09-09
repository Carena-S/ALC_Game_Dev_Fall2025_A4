using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveUp : MonoBehaviour
{
    public float speed;

    void Start()
    {

    }
    void Update()
    {
        //Move the ballon up on the y axis at a set rate of speed
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}

