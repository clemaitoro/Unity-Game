using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 8, 0);
    }

    // Update is called once per frame
    public float speed = 10;
    public float turnspeed = 40;
    public float rotationstyle;
    public float horizontalInput;
    public float vericalInput;
    public float xRange = 25;
    public float zRange = 8;
    public GameObject ProjectilePrefab;


    void Update()
    {
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -xRange + 8)
        {
            transform.position = new Vector3(-xRange + 8, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -zRange - 8  )
        {
           transform.position = new Vector3(transform.position.x, transform.position.y, -zRange - 8);
        }
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        vericalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * vericalInput);
        transform.Rotate(Vector3.up, turnspeed * horizontalInput * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ProjectilePrefab, transform.position, ProjectilePrefab.transform.rotation);
        }
    }
}
