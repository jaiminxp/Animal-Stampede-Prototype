using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    bool isDogReady = true;
    float waitTime = 0.5f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && isDogReady)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            isDogReady = false;
            Invoke(nameof(DogReady), waitTime);
        }
    }

    void DogReady()
    {
        isDogReady = true;
    }
}
