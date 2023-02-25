using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public GameObject Rocket;
    void Update()
    {
        
    }
     void OnTriggerEnter(Collider other)
    {
        Destroy(Rocket);
        Destroy(other.gameObject);
    }
}
