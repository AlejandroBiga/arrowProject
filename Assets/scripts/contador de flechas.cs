using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contadordeflechas : MonoBehaviour
{

    public int arrowCount = 0;
    public GameObject panelResultados;

    private void Start()
    {
        panelResultados.SetActive(false);
    }
    private void Update()
    {
        CountArrows();

        if (arrowCount == 3)
        {
            panelResultados.SetActive(true);
        }
    }

    void CountArrows()
    {
        GameObject[] arrowObjects = GameObject.FindGameObjectsWithTag("arrow");
        arrowCount = arrowObjects.Length;
    }

}
