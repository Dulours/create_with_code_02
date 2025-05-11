using UnityEngine;

public class S_SpawnManager : MonoBehaviour
{
    public GameObject[ ] animalPrefabs;
    private float spawnPosZ = 20f;
    private float spawnRangeX = 20f;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Call the SpawnRandomAnimal method every x seconds after a certain delay
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        // Randomly generate an animal index
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        // Randomly generate a spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        // Spawn animal
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
