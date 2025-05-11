using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool canSpawnDog = true;
    public float spawnDelay = 0.5f;
    private float timeElapsed = 0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canSpawnDog)
        {
            SpawnDog();
        }
        else if (!canSpawnDog)
        {
            timeElapsed += Time.deltaTime;
            if (timeElapsed > spawnDelay)
            {
                canSpawnDog = true;
            }
        }
    }

    void SpawnDog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        canSpawnDog = false;
        timeElapsed = 0f;
        
    }
}
