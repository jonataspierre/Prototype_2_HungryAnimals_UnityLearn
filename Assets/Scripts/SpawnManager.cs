using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    
    [Header("Top")]
    private float spawnTopRangeX = 12.0f;
    private float spawnTopRangeZ = 14.0f;
    private float startSpawnTopDelay = 1.0f;
    private float spawnTopInterval = 3f;

    [Header("Left")]
    private float spawnLeftRangeZ = 6.0f;
    private float spawnLeftRangeX = -18.0f;
    private float startSpawnLeftDelay = 1.5f;
    private float spawnLeftInterval = 3f;

    [Header("Right")]
    private float spawnRightRangeZ = -6.0f;
    private float spawnRightRangeX = 18.0f;
    private float startSpawnRightDelay = 2.0f;
    private float spawnRightInterval = 3f;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalTop", startSpawnTopDelay, spawnTopInterval);
        InvokeRepeating("SpawnRandomAnimalLeft", startSpawnLeftDelay, spawnLeftInterval);
        InvokeRepeating("SpawnRandomAnimalRight", startSpawnRightDelay, spawnRightInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimalTop()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        
        // Spawn Top
        Vector3 spawnTopPos = new Vector3(Random.Range(-spawnTopRangeX, spawnTopRangeX), 0, spawnTopRangeZ);
        Instantiate(animalPrefabs[animalIndex], spawnTopPos, animalPrefabs[animalIndex].transform.rotation);        
    }

    void SpawnRandomAnimalLeft()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        // Spawn Left
        Vector3 spawnLeftPos = new Vector3(spawnLeftRangeX, 0, Random.Range(-spawnLeftRangeZ, spawnLeftRangeZ));
        Vector3 leftRotation = new Vector3(0, 90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnLeftPos, Quaternion.Euler(leftRotation));
    }

    void SpawnRandomAnimalRight()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        // Spawn Left
        Vector3 spawnRightPos = new Vector3(spawnRightRangeX, 0, Random.Range(-spawnRightRangeZ, spawnRightRangeZ));
        Vector3 RightRotation = new Vector3(0, -90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnRightPos, Quaternion.Euler(RightRotation));
    }
}
