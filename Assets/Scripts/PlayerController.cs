using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Read Input")]
    public float horizontalInput;
    [Header("Speed Player")]
    public float speedPlayer = 12.0f;
    [Header("Boundaries")]
    public float xRange = 12.0f;
    [Header("Food Prefab")]
    public GameObject foodPrefab;
    
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
    }

    void Move()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speedPlayer * horizontalInput);
    }

    void Boundaries()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }

    void LaunchFood()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(foodPrefab, transform.position, foodPrefab.transform.rotation);
        }
    }
}
