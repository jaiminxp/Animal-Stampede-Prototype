using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private int minSpawnInterval = 2;
    private int maxSpawnInterval = 5;

    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(SpawnRandomBall), startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        GameObject randomBall = Sample(ballPrefabs);

        // instantiate ball at random spawn location
        Instantiate(randomBall, spawnPos, randomBall.transform.rotation);

        int spawnBallInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
        Invoke(nameof(SpawnRandomBall), spawnBallInterval);
    }

    T Sample<T>(T[] array)
    {
        int randomIndex = Random.Range(0, array.Length);
        return array[randomIndex];
    }

}
