using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float HealthPoints = 3;
    public GameObject Rocket;
    void Update()
    {

        if( HealthPoints == null)
        {
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        HealthPoints -=1;
        Destroy(Rocket);
        
    }
}

