using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomController : MonoBehaviour
{
    public Camera playerCamera;
    public Slider zoomSlider; 

    public float zoomSpeed = 5.0f;
    public float minFOV = 20.0f; 
    public float maxFOV = 60.0f; 

    void Start()
    {
        
        zoomSlider.value = Mathf.InverseLerp(minFOV, maxFOV, playerCamera.fieldOfView);

        
        zoomSlider.onValueChanged.AddListener(OnZoomSliderChanged);
    }

    void OnZoomSliderChanged(float value)
    {
        
        float newFOV = Mathf.Lerp(minFOV, maxFOV, value);

        
        playerCamera.fieldOfView = newFOV;
    }
}
