using UnityEngine;
using UnityEngine.UI;

public class S_Hunger : MonoBehaviour
{

    public int hungerPoints;
    private int minHungerPoints = 1;
    private int maxHungerPoints = 4;
    public Slider hungerSlider;
    private float toBeFed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hungerPoints = Random.Range(minHungerPoints, maxHungerPoints);
        toBeFed = hungerPoints;
        hungerSlider.maxValue = toBeFed;
    }

    // Update is called once per frame
    void Update()
    {
        hungerSlider.value = hungerPoints;
    }
}
