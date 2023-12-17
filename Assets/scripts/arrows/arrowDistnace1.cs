using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class arrowDistnace1 : MonoBehaviour
{
    public string targetTag = "Target";
    public string textTag = "textOro";
    private Transform target;
    private TextMeshProUGUI distanceText;
    

    private void Start()
    {
        GameObject targetObject = GameObject.FindGameObjectWithTag(targetTag);

        if (targetObject != null)
        {
            
            target = targetObject.transform;
        }

        GameObject textObject = GameObject.FindGameObjectWithTag(textTag);

        if (textObject != null)
        {
            distanceText = textObject.GetComponent<TextMeshProUGUI>();
        }
        
    }

    private void Update()
    {
        if (target != null)
        {
            
            float distance = Vector3.Distance(transform.position, target.position);

            
            Debug.Log($"Distancia entre {gameObject.name} y {target.name}: {distance}");


            if (distance <= 1.45)
            {
                distanceText.text = "En el blanco";
            }
            else
            {
                distanceText.text = $"Distancia: {distance.ToString("F2")} Metros";
            }

            
        }
    }

}