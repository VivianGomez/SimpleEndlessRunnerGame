using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SeleccionarNivel1()
    {
        PlayerPrefs.SetInt("level", 1);
        PlayerPrefs.SetInt("score", 60);
        PlayerPrefs.SetInt("rapidezObstaculo", 10);
        PlayerPrefs.SetInt("penalizacion", 3);

        SceneManager.LoadScene("MainScene");
    }

    public void SeleccionarNivel2()
    {
        PlayerPrefs.SetInt("level", 2);
        PlayerPrefs.SetInt("score", 120);
        PlayerPrefs.SetInt("rapidezObstaculo", 15);
        PlayerPrefs.SetInt("penalizacion", 5);

        SceneManager.LoadScene("MainScene");
    }
}
