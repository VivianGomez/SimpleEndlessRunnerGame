using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal") * 5;
        rb.velocity = new Vector3 (movimientoHorizontal, rb.velocity.y, rb.velocity.z);
    }
}
