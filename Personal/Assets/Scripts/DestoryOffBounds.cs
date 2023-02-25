using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOffBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float lowerBound = -45;
    
    void Update()
    {
        if(transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
        
    }
}
