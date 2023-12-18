using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ArrowController : MonoBehaviour
{
    // Referencias a las flechas y al objetivo
    public GameObject flecha1;
    public GameObject flecha2;
    public GameObject flecha3;
    public GameObject objetivo;

    // Referencias a los objetos TextMeshPro
    public TextMeshProUGUI distanciaTexto1;
    public TextMeshProUGUI distanciaTexto2;
    public TextMeshProUGUI distanciaTexto3;

    void Update()
    {
        // Obtener la posición del objetivo
        Vector3 posicionObjetivo = objetivo.transform.position;

        // Calcular la distancia entre cada flecha y el objetivo
        float distancia1 = Vector3.Distance(posicionObjetivo, flecha1.transform.position);
        float distancia2 = Vector3.Distance(posicionObjetivo, flecha2.transform.position);
        float distancia3 = Vector3.Distance(posicionObjetivo, flecha3.transform.position);

        // Actualizar los objetos TextMeshPro con las distancias
        distanciaTexto1.text = "Distancia Flecha 1: " + distancia1.ToString("F2") + " unidades";
        distanciaTexto2.text = "Distancia Flecha 2: " + distancia2.ToString("F2") + " unidades";
        distanciaTexto3.text = "Distancia Flecha 3: " + distancia3.ToString("F2") + " unidades";
    }

}
