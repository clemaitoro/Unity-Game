using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnOmuleti", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    public GameObject[] omuletiDreapta;
    public float rangeX = 10;
    public float rangez = 6;
    public float spawnDelay = 2;
    public float spawnInterval = 3;
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
        int OmuletiIndex = Random.Range(0, omuletiDreapta.Length);
        Vector3 spawnPos = new Vector3(rangeX, 1, Random.Range(rangez, -rangez));
        Instantiate(omuletiDreapta[OmuletiIndex], new Vector3(rangeX, 1, Random.Range(-rangez, rangez)), omuletiDreapta[OmuletiIndex].transform.rotation);
        
    }
}
