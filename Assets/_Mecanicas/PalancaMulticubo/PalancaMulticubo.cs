using UnityEngine;
using TMPro;
using UnityEditor;

public class PalancaMulticubo : MonoBehaviour
{
  
    public GameObject texto;
    bool enTrigger;
    public CuboElevador[] cubosElevadores;
    bool palancaPosicionOn;
    
    public Quaternion palancaIzquierda;
    public Quaternion palancaDerecha;

    public Transform pivote;

    void Start()
    {
        texto.SetActive(false);
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
            for (int i = 0; i < cubosElevadores.Length; i++)
            {
                cubosElevadores[i].CerrarPuerta();
            }
            
            pivote.rotation = palancaDerecha;
        }
        else
        {
            for (int i = 0; i < cubosElevadores.Length; i++)
            {
                cubosElevadores[i].AbrirPuerta();
            }
            
            pivote.rotation = palancaIzquierda;
        }
        palancaPosicionOn = !palancaPosicionOn;
    }
}

