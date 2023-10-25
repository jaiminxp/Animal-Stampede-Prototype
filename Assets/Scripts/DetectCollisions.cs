using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
