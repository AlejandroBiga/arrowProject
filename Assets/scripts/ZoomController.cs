using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomController : MonoBehaviour
{
    public Camera Cam1;
    public Camera Cam3;
    public Camera Cam4;
    public Slider zoomSlider; 

    public float zoomSpeed = 5.0f;
    public float minFOV = 20.0f; 
    public float maxFOV = 60.0f; 

    void Start()
    {   
        zoomSlider.value = Mathf.InverseLerp(minFOV, maxFOV, Cam1.fieldOfView);
        zoomSlider.value = Mathf.InverseLerp(minFOV, maxFOV, Cam3.fieldOfView);
        zoomSlider.value = Mathf.InverseLerp(minFOV, maxFOV, Cam4.fieldOfView);
        zoomSlider.onValueChanged.AddListener(OnZoomSliderChanged);
    }

    void OnZoomSliderChanged(float value)
    {     
        float newFOV = Mathf.Lerp(minFOV, maxFOV, value);
        Cam1.fieldOfView = newFOV;
        Cam3.fieldOfView = newFOV;
        Cam4.fieldOfView = newFOV;
    }
}
