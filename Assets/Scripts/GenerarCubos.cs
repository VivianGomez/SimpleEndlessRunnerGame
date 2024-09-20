using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarCubos : MonoBehaviour
{
    public GameObject obstaculoPrefab;

    public Transform posicionGeneradora;
    public Transform[] otrasPosiciones; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Jugador")
        {
            if (PlayerPrefs.GetInt("level") == 1)
            {
                Instantiate(obstaculoPrefab, posicionGeneradora.position, Quaternion.identity);
            }
            else if (PlayerPrefs.GetInt("level") == 2)
            {
                int randomIndex = Random.Range(0, otrasPosiciones.Length);
                Instantiate(obstaculoPrefab, posicionGeneradora.position, Quaternion.identity);
                Instantiate(obstaculoPrefab, otrasPosiciones[randomIndex].position, Quaternion.identity);
            }
        }
    }
}

