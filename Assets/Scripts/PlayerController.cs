using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;


    public TextMeshProUGUI txtPuntos;
    public float score;

    bool finJuego = false;
    public GameObject panelFinJuego;

    void Start()
    {
        txtPuntos.text = "0";
    }

    void Update()
    {
        score += Time.deltaTime;
        txtPuntos.text = Mathf.RoundToInt(score).ToString();
         
        if(score >= PlayerPrefs.GetInt("score") && !finJuego)
        {
            panelFinJuego.SetActive(true);
            TextMeshProUGUI txtMensaje = panelFinJuego.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
            txtMensaje.text += PlayerPrefs.GetInt("level");
            finJuego = true;
        }
    }

    void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal") * 5;
        rb.velocity = new Vector3 (movimientoHorizontal, rb.velocity.y, rb.velocity.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("Obstaculo"))
        {
            DisminuirScore(PlayerPrefs.GetInt("penalizacion"));
            GameObject.Find("Main Camera").GetComponent<Camera>().backgroundColor = Color.red;
            Destroy(other.gameObject);
            StartCoroutine(CambiarColorCamara());
        }
    }

    public IEnumerator CambiarColorCamara()
    {
        yield return new WaitForSeconds(0.5f);
        Color colorRGB = new Color(0.7888221f, 0.8867924f, 0.7813812f);
        GameObject.Find("Main Camera").GetComponent<Camera>().backgroundColor = colorRGB;
    }

    public void DisminuirScore(float penalizacion)
    {
        score -= penalizacion;
    }
}
