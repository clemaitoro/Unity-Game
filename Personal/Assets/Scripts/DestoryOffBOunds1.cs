using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOffBOunds1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float topBound = 30;
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        
    }
}
