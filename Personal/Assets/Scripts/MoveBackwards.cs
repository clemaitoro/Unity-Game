using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackwards : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float speed = -10;
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
