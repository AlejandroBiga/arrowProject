using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WIndZoneScript : MonoBehaviour
{
    public Vector3 WindDirection;

    List<GameObject> ArrowsInWindArea = new List<GameObject>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("arrow"))
        {
            ArrowsInWindArea.Add(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("arrow"))
        {
            ArrowsInWindArea.Remove(other.gameObject);
        }
    }

    private void FixedUpdate()
    {
        if(ArrowsInWindArea.Count > 0)
        {
            foreach(GameObject arrow in ArrowsInWindArea)
            {
                arrow.GetComponent<Rigidbody>().velocity += WindDirection * Time.deltaTime;
            }
        }
    }
}
