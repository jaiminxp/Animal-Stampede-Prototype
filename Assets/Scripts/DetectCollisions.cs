using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.UpdateLives(-1);
            Destroy(gameObject);
        }
        else
        {
            gameManager.UpdateScore(5);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
