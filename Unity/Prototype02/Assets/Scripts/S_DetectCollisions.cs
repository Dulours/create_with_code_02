using UnityEngine;

public class S_DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Destroy current gameobject and collided game object when collision is detected
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
