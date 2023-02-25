using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        
    }

    // Update is called once per frame
    public GameObject[] inamici;
    public float spawnRangex = 0;
    public float spawnRangez = 22;
    public float startDelay = 2;
    public float spawnInterval = 5.0f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }
        
    }
    void SpawnRandomAnimal()
    {
        int InamiciIndex = Random.Range(0, inamici.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-8,14), 8,  spawnRangez);
        Instantiate(inamici[InamiciIndex], new Vector3(Random.Range(-8, 14),8,22), inamici[InamiciIndex].transform.rotation );
    }
}
