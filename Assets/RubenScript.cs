using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubenScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;

    public float yapStrength;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.velocity = Vector2.up * yapStrength;
        }
    }
}