using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject taperPipes;
    
    public float spawnRate = 2;

    private float clock = 0;

    public float heightOffset = 1.1f;
     
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    void Update()
    {
        if (clock < spawnRate)
        {
            clock = clock + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            clock = 0;
        }
        
    }

    void spawnPipe()
    { 
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        
        Instantiate(taperPipes, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
