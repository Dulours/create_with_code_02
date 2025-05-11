using UnityEngine;

public class S_DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Dog")
        {
            S_Hunger hungerScript = other.GetComponent<S_Hunger>();
            if(hungerScript.hungerPoints > 1)
            {
                hungerScript.hungerPoints -= 1;
                Destroy(gameObject);
            }
            else if (hungerScript.hungerPoints <= 1)
            {
                Destroy(gameObject);
                Destroy(other.gameObject);
            }
        }
    }
}
