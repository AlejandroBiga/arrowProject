using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindZone : MonoBehaviour
{
    public float fuerzaViento = 5f;

    // Start is called before the first frame update
    void Start()
    {
        WindZone windZone = GetComponent<WindZone>();
        Vector3 direccionViento = windZone.transform.forward;

        AplicarFuerzaViento(direccionViento * fuerzaViento);
    }

    void AplicarFuerzaViento(Vector3 fuerza)
    {
        Rigidbody rbFlecha = GetComponent<Rigidbody>();
        if (rbFlecha != null)
        {
            rbFlecha.AddForce(fuerza, ForceMode.Force);
        }
    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
