using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOffBoundsLast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float leftBound = -15;
    void Update()
    {
        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
    }
}
