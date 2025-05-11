using UnityEngine;

public class S_PlayerController : MonoBehaviour
{
    // Movement
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10f;
    public float xRange = 15f;
    public float zRangeMax = 15f;
    public float zRangeMin = -1.0f;
    public float playerHealth = 3f;

    public GameObject projectile;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print(playerHealth);
    }

    // Update is called once per frame
    void Update()
    {
        // Clamp player position inside xRange and zRange
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.z > zRangeMax)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeMax);
        }
        if (transform.position.z < zRangeMin)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeMin);
        }

        // Move the player left and right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        // Launch projectile when pressing spacebar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectile, transform.position, projectile.transform.rotation);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Dog")
        {
            playerHealth -= 1;
            print(playerHealth);
            if (playerHealth <= 0)
            {
                Debug.Log("Game over!");
            }
        }
    }
}   
