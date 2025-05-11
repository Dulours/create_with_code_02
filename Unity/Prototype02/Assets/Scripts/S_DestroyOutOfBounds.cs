using UnityEngine;

public class S_DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    private float sideBound = 40f;
    public GameObject player;
    private S_PlayerController controller;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player");
        controller = player.GetComponent<S_PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy the object if it leaves the defined boundaries
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.x > sideBound || transform.position.x < -sideBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            controller.playerHealth -= 1;
            print(controller.playerHealth);
            if (controller.playerHealth <= 0)
            {
                Debug.Log("Game over!");
            }
        }
        
    }
}
