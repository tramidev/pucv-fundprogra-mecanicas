using UnityEngine;
using TMPro;
using UnityEditor;

public class Palanca : MonoBehaviour
{
    public GameObject puerta;
    public GameObject texto;
    public bool puertaAbierta;
    bool enTrigger;
    public CuboElevador cuboElevador;
    bool palancaPosicionOn;
    
    public Quaternion palancaIzquierda;
    public Quaternion palancaDerecha;

    public Transform pivote;

    void Start()
    {
        texto.SetActive(false);
        puertaAbierta = false;
        enTrigger = false;
        pivote.rotation = palancaDerecha;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.X) && enTrigger)
        {
            AccionarPalanca();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        texto.SetActive(true);
        enTrigger = true;
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        texto.SetActive(false);
        enTrigger = false;
    }

    void AccionarPalanca()
    {
        
        if (palancaPosicionOn)
        {
            cuboElevador.CerrarPuerta();
            pivote.rotation = palancaDerecha;
        }
        else
        {
            cuboElevador.AbrirPuerta();
            
            pivote.rotation = palancaIzquierda;
        }
        palancaPosicionOn = !palancaPosicionOn;
    }
}

