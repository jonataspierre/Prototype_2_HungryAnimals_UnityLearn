using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 20.0f;
    private float lowerBound = -12.0f;
    public float sideBound = 25.0f;

    public GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // If a object goes past the players view in the game, remove that object
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            //Debug.Log("Game Over!");
            gameManager.AddLives(-1);
            Destroy(gameObject);    
        }

        if (transform.position.x > sideBound || transform.position.x < -sideBound)
        {
            //Debug.Log("Game Over!");
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
