using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjetiveSlider : MonoBehaviour
{
    public Slider slider;
    public GameObject movableObject;
    public float maxDistance = 10f; 
    private float initialZPosition;

    private void Start()
    {
        initialZPosition = movableObject.transform.position.z;
    }
    private void Update()
    {
        
        float sliderValue = slider.value;
        float newZPos = Mathf.Lerp(initialZPosition - maxDistance / 2f, initialZPosition + maxDistance / 2f, sliderValue);
        movableObject.transform.position = new Vector3(
            movableObject.transform.position.x,
            movableObject.transform.position.y,
            newZPos);
    }
}
