using TMPro;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    int contador;
    public TextMeshProUGUI textoEjemplo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Inicio");
        contador = 0;
        textoEjemplo.text = "hola";
    }

    // Update is called once per frame
    void Update()
    {
        contador = contador + 1;
        Debug.Log("En cada actualizacion, "+ contador);
    }
}
