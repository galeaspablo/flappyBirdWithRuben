using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovementScript : MonoBehaviour
{
    // transform is not needed, because it's already part of MonoBehaviour
    public float warpSpeed  = 5;
    public float deadZone = -15;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * warpSpeed) * Time.deltaTime;
        
        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe destroyed");
            Destroy(gameObject);
        }
    }
}

