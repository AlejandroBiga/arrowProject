using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowStick : MonoBehaviour
{
    public Rigidbody rb;
    public Collider collider1;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        collider1 = GetComponent<Collider>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.isKinematic = true;
        collider1.enabled = false;
    }
}
