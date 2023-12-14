using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class WindZoneController : MonoBehaviour
{
    public GameObject[] windZones;
    public UnityEngine.UI.Toggle[] toggles;

    void Start()
    {
        for (int i = 0; i < Mathf.Min(windZones.Length, toggles.Length); i++)
        {
            int index = i;
            toggles[i].onValueChanged.AddListener((value) => ToggleWindZone(index, value));
        }
    }

    void ToggleWindZone(int index, bool isActive)
    {
        windZones[index].SetActive(isActive);
        
    }
}
