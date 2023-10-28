using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int score = 0;
    int lives = 3;

    public void UpdateLives(int value)
    {
        lives += value;

        if (lives <= 0)
        {
            Debug.Log("Game Over");
            lives = 0;
        }

        Debug.Log("Lives: " + lives);
    }

    public void UpdateScore(int value)
    {
        score += value;
        Debug.Log("Score: " + score);
    }
}
