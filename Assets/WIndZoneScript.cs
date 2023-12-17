using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WIndZoneScript : MonoBehaviour
{
    public Vector3 WindDirection;
    public Slider XInput;
    public Slider YInput;
    public Slider ZInput;
    public GameObject WindPanel;
    public GameObject ObjPanel;
    List<GameObject> ArrowsInWindArea = new List<GameObject>();
    public TextMeshProUGUI Xtext;
    public TextMeshProUGUI Ytext;
    public TextMeshProUGUI Ztext;

    
    private void Start()
    {
        ObjPanel.SetActive(false);
    }

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

    private void Update()
    {
        Xtext.text = "" + XInput.value;
        Ytext.text = "" + YInput.value;
        Ztext.text = "" + ZInput.value;

    }

    public void ApplyWindZoneInput()
    {
        WindDirection.x = XInput.value;
        WindDirection.y = YInput.value;
        WindDirection.z = ZInput.value;
        ObjPanel.SetActive(true);
        WindPanel.SetActive(false); 
    }

}
