using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BowShooting : MonoBehaviour
{
    public float ArrowForce;
    public float objectLifetime = 3;
    public GameObject Arrow;
    public Transform ArrowSpawner;
    public Slider ForceSlider;
    public TextMeshProUGUI ForceText;
    public float torque;

    
    public void Update()
    {
        ArrowForce = ForceSlider.value;
        ForceText.text = "Force: " + ForceSlider.value;
    }

    public void ShootArrow()
    {
        GameObject ArrowClone = Instantiate(Arrow, ArrowSpawner.position, ArrowSpawner.rotation);
        Rigidbody ArrowRB = ArrowClone.GetComponent<Rigidbody>();
        ArrowRB.AddRelativeForce(Vector3.up * ArrowForce, ForceMode.Impulse);
        ArrowRB.AddTorque(transform.right * torque);

        
    }
}
