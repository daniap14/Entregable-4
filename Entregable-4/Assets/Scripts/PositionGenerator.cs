using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionGenerator : MonoBehaviour
{
    public Vector3 RandomPosition()
    {
        float randomx = Random.Range(0, 8);
        float randomz = Random.Range(0, 8);
        float randomy = Random.Range(0, 8);

        return new Vector3(randomx, randomy, randomz);

    }

    // Start is called before the first frame update
    void Start()
    {
       
        // transform.position = new Vector3(Random.Range(0, 8), Random.Range(0, 8), Random.Range(0, 8));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = RandomPosition();
        }
    }
}
