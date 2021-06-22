using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Read Input")]
    public float horizontalInput;
    public float verticalInput;
    [Header("Speed Player")]
    public float speedPlayer = 12.0f;
    [Header("Boundaries")]
    public float xRange = 15.0f;
    public float zRange = 9.2f;
    [Header("Food Prefab")]
    public GameObject foodPrefab;
    public Transform projectileSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ReadInput();

        Boundaries();

        Move();

        LaunchFood();
    }

    void ReadInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    void Move()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speedPlayer * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speedPlayer * verticalInput);
    }

    void Boundaries()
    {
        // Vertical bound
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Horizontal bound
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        else if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
    }

    void LaunchFood()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(foodPrefab, projectileSpawnPoint.position, foodPrefab.transform.rotation);
        }
    }
}
