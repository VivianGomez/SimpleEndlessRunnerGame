using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarCubos : MonoBehaviour
{
    public GameObject cuboPrefab;
    public Transform posicionGeneradora;
    public Transform[] otrasPosiciones;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Jugador")
        {
            if (PlayerPrefs.GetInt("level") == 1)
            {
                Instantiate(cuboPrefab, posicionGeneradora.position, Quaternion.identity);
            }
            else if (PlayerPrefs.GetInt("level") == 2)
            {
                int randomIndex = Random.Range(0, otrasPosiciones.Length);
                Instantiate(cuboPrefab, posicionGeneradora.position, Quaternion.identity);
                Instantiate(cuboPrefab, otrasPosiciones[randomIndex].position, Quaternion.identity);
            }
        }
    }
}

