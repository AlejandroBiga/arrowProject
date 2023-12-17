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
    public GameObject CobreArrow;
    public GameObject OroArrow;
    public GameObject PlumaArrow;
    public Transform ArrowSpawner;
    public Slider ForceSlider;
    public TextMeshProUGUI ForceText;
    public void Update()
    {
        ArrowForce = ForceSlider.value;
        ForceText.text = "" + ForceSlider.value;
    }

    public void ShootArrow()
    {
        GameObject ArrowClone = Instantiate(Arrow, ArrowSpawner.position, ArrowSpawner.rotation);
        Rigidbody ArrowRB = ArrowClone.GetComponent<Rigidbody>();
        ArrowRB.AddRelativeForce(Vector3.up * ArrowForce, ForceMode.Impulse);
        StartCoroutine(DeactivateObject(ArrowClone));
    }

    IEnumerator DeactivateObject(GameObject objToDeactivate)
    {
        yield return new WaitForSeconds(objectLifetime);
        Destroy(objToDeactivate);
    }

    public void ShootCobreArrow()
    {
        GameObject ArrowClone = Instantiate(CobreArrow, ArrowSpawner.position, ArrowSpawner.rotation);
        Rigidbody ArrowRB = ArrowClone.GetComponent<Rigidbody>();
        ArrowRB.AddRelativeForce(Vector3.up * ArrowForce, ForceMode.Impulse);
        StartCoroutine(DeactivateObject(ArrowClone));
    }
    public void ShootOroArrow()
    {
        GameObject ArrowClone = Instantiate(OroArrow, ArrowSpawner.position, ArrowSpawner.rotation);
        Rigidbody ArrowRB = ArrowClone.GetComponent<Rigidbody>();
        ArrowRB.AddRelativeForce(Vector3.up * ArrowForce, ForceMode.Impulse);
        StartCoroutine(DeactivateObject(ArrowClone));
    }
    public void ShootPlumaArrow()
    {
        GameObject ArrowClone = Instantiate(PlumaArrow, ArrowSpawner.position, ArrowSpawner.rotation);
        Rigidbody ArrowRB = ArrowClone.GetComponent<Rigidbody>();
        ArrowRB.AddRelativeForce(Vector3.up * ArrowForce, ForceMode.Impulse);
        StartCoroutine(DeactivateObject(ArrowClone));
    }
}
