using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }   

    private void OnTriggerEnter(Collider other)
    {
        //Destroy(gameObject);
        //Destroy(other.gameObject);

        if (other.CompareTag("Player"))
        {
            //Debug.Log("Game Over!");
            gameManager.AddLives(-1);            
            Destroy(gameObject);
        }
        else if (other.CompareTag("Animals"))
        {
            gameManager.AddScore(+1);            
            Destroy(other.gameObject);
            Destroy(gameObject);
        }        
    }
}
