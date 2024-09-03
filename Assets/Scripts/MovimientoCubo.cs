using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCubo : MonoBehaviour
{
    public Rigidbody rb;
    public float rapidez = 5f; 

    void Start()
    {

    }

    void FixedUpdate()
    {
        Vector3 velocidad = new Vector3(0, 0, -rapidez);
        rb.velocity = velocidad;
    }
}
