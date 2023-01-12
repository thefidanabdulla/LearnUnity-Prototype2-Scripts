using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 15;
    private float spawnRangeZ = 15;
    private float startDelay = 2f;
    private float spawnInterval = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        int randomPos = Random.Range(0, 2);
        Vector3 spawnPos;
        if (randomPos == 0)
        {
            spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
        else
        {
            spawnPos = new Vector3(25, 0, Random.Range(3, spawnRangeZ));
            Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(new Vector3(0, 270, 0)));
        }

    }
}
