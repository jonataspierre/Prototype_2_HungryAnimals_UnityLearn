using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    private int lives = 3;
    
    public void AddLives(int value)
    {
        lives += value;

        if (lives <= 0)
        {
            Debug.Log("Game Over!");
            lives = 0;
        }
    }

    public void AddScore(int value)
    {
        score += value;
        
        Debug.Log("Score : " + score);        
    }
}
