using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class WindZoneController : MonoBehaviour
{
    public WindZone[] windZones;
    public UnityEngine.UI.Button[] botones;


    void Start()
    {
        for (int i = 0; i < Mathf.Min(windZones.Length, botones.Length); i++)
        {
            int index = i; 
            botones[i].onClick.AddListener(() => ActivarDesactivarWindZone(windZones[index]));
        }
    }

    public void ActivarDesactivarWindZone(WindZone windZone)
    {
        windZone.enabled = !windZone.enabled;

    }
}
