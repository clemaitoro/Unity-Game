﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public bool ShouldDestroyOnDeath = true;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame

    
    void Update()

    {
     
        
    }
    public float HealthPoints
    {
        get
        {
            return _HealthPoins;
        }
        set
        {
            _HealthPoints = value;

            if (HealthPoints <= 0)
            {
                if (ShouldDestroyOnDeath)
                    Destroy(gameObject);
            }

        }
    }
    public float _HealthPoints = 3f;
    private float _HealthPoins;
}

