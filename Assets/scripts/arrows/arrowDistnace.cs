using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class arrowDistnace : MonoBehaviour
{
    public string targetTag = "Target";
    public string textObjectName = "pluma";  // Cambia "YourTextObjectName" al nombre real de tu objeto de texto
    private Transform target;
    private TextMeshProUGUI distanceText;

    private void Start()
    {
        GameObject targetObject = GameObject.FindGameObjectWithTag(targetTag);

        if (targetObject != null)
        {
            target = targetObject.transform;
        }

        GameObject textObject = GameObject.Find(textObjectName);

        if (textObject != null)
        {
            distanceText = textObject.GetComponent<TextMeshProUGUI>();
        }
    }

    private void Update()
    {
        if (target != null && distanceText != null)
        {
            float distance = Vector3.Distance(transform.position, target.position);

            Debug.Log($"Distancia entre {gameObject.name} y {target.name}: {distance}");

            if (distance <= 2.56f)
            {
                distanceText.text = "En el blanco";
            }
            else
            {
                distanceText.text = $"Distancia: {distance.ToString("F2")} unitys";
            }
        }
    }

}
