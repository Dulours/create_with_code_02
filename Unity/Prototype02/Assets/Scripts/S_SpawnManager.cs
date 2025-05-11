using UnityEngine;
using UnityEngine.UIElements;

public class S_SpawnManager : MonoBehaviour
{
    public GameObject[ ] animalPrefabs;
    private float spawnPosZ = 20f;
    private float spawnPosX = 30f;
    private float spawnRangeX = 20f;
    private float spawnRangeZ = 15f;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Call the SpawnRandomAnimal method every x seconds after a certain delay
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalRight", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalLeft", startDelay, spawnInterval);
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

    void SpawnRandomAnimalRight()
    {
        // Randomly generate an animal index
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        // Randomly generate a spawn position
        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(0, spawnRangeZ));
        Quaternion spawnRot = Quaternion.Euler(animalPrefabs[animalIndex].transform.rotation.x, 270, animalPrefabs[animalIndex].transform.rotation.z);
        // Spawn animal
        Instantiate(animalPrefabs[animalIndex], spawnPos, spawnRot);
    }

    void SpawnRandomAnimalLeft()
    {
        // Randomly generate an animal index
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        // Randomly generate a spawn position
        Vector3 spawnPos = new Vector3(-spawnPosX, 0, Random.Range(0, spawnRangeZ));
        Quaternion spawnRot = Quaternion.Euler(animalPrefabs[animalIndex].transform.rotation.x, -270, animalPrefabs[animalIndex].transform.rotation.z);
        // Spawn animal
        Instantiate(animalPrefabs[animalIndex], spawnPos, spawnRot);
    }
}
