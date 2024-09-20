using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorPremios : MonoBehaviour
{
    public GameObject premioPrefab;
    public Transform[] posiciones;

    void Start()
    {
        InvokeRepeating("GenerarPremios", 0f, 3f);
    }

    public void GenerarPremios()
    {
        int randomIndex = Random.Range(0, posiciones.Length);
        Instantiate(premioPrefab, posiciones[randomIndex].position, premioPrefab.transform.rotation);
    }
}
