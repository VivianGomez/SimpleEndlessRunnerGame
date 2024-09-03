using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarCubos : MonoBehaviour
{
    public GameObject cuboPrefab;
    public Transform posicionGeneradora;

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(cuboPrefab, posicionGeneradora.position, Quaternion.identity);
    }
}

