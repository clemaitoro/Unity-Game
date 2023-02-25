using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnOmuleti", startDelaty, spawnInterval);
    }

    // Update is called once per fram
    public GameObject[] omuletiStanga;
    public float spawnRangeX = -10;
    public float spawnRangeZ = -6;
    public float startDelaty = 2;
    public float spawnInterval = 1;
    public float speed = 10;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnOmuleti();
        }
        
    }
     void SpawnOmuleti()
    {
        int OmuletiIdex = Random.Range(0, omuletiStanga.Length);
        Vector3 spawnPos = new Vector3(spawnRangeX, 1, Random.Range(-spawnRangeZ, spawnRangeZ));
        Instantiate(omuletiStanga[OmuletiIdex], new Vector3(spawnRangeX, 1, Random.Range(-10, 8)), omuletiStanga[OmuletiIdex].transform.rotation);
        


    }
}
