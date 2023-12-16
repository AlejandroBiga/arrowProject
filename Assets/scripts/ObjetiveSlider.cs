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
    public GameObject ObjPanel;
    public GameObject ShootButton;
    public GameObject BowPanel;

    private void Start()
    {
        initialZPosition = movableObject.transform.position.z;
    }
    public void ApplyObjectPos()
    {  
        float sliderValue = slider.value;
        float newZPos = Mathf.Lerp(initialZPosition - maxDistance / 2f, initialZPosition + maxDistance / 2f, sliderValue);
        movableObject.transform.position = new Vector3(
            movableObject.transform.position.x,
            movableObject.transform.position.y,
            newZPos);
    }

    public void StartSim()
    {
        ObjPanel.SetActive(false);
        ShootButton.SetActive(true);
        BowPanel.SetActive(true);
    }
}
