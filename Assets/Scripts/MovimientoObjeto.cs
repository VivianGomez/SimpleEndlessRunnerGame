using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoObjeto : MonoBehaviour
{
    public Rigidbody rb;
    public float rapidez = 5f; 

    void Start()
    {
        rapidez = PlayerPrefs.GetInt("rapidezObstaculo");
    }

    void FixedUpdate()
    {
        Vector3 velocidad = new Vector3(0, 0, -rapidez);
        rb.velocity = velocidad;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Destructor")
        {
            Destroy(gameObject);
        }
    }

}
