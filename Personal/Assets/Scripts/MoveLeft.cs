using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //new Vector3(0, -90, 0);
    }

    // Update is called once per frame
    public float speed = 10;
    void Update()
    {
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
