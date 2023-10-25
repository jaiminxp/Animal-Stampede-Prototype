using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animals;
    private float spawnRangeX = 15;
    private float spawnPosZ = 20;
    private float spawnDelay = 2;
    private float spawnInterval = 1.5f;
    float sideSpawnMinZ = 3;
    float sideSpawnMaxZ = 15;
    float sideSpawnX = 20;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnDelay, spawnInterval);
        InvokeRepeating("SpawnLeftAnimal", spawnDelay, spawnInterval);
        InvokeRepeating("SpawnRightAnimal", spawnDelay, spawnInterval);
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animals.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animals[animalIndex], spawnPos, animals[0].transform.rotation);
    }

    void SpawnLeftAnimal()
    {
        int animalIndex = Random.Range(0, animals.Length);
        Vector3 spawnPos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, 90, 0);

        Instantiate(animals[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }

    void SpawnRightAnimal()
    {
        int animalIndex = Random.Range(0, animals.Length);
        Vector3 spawnPos = new Vector3(sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, 90, 0);

        Instantiate(animals[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }
}
