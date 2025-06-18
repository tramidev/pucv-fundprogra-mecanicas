using UnityEngine;

public class CuboElevador : MonoBehaviour
{
    public GameObject texto;
    public Vector3 puntoFinal;
    private bool puertaAbierta;
    private bool playerInteractuando;

    private void Start()
    {
        PrenderTexto(false);
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.F) && playerInteractuando)
        {
            Debug.Log("Usuario Presionó tecla F");
            
            AbrirPuerta();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PrenderTexto(false);
        Debug.Log("Mensaje Entrada");
        playerInteractuando = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Mensaje Salida");
        PrenderTexto(false);
        playerInteractuando = false;
    }

    void AbrirPuerta()
    {
        if (!puertaAbierta)
        {
            texto.SetActive(false);
            puertaAbierta = true;
            transform.position = transform.position + puntoFinal;
        }
    }

    void PrenderTexto(bool prender)
    {
        if (!puertaAbierta)
        {
            texto.SetActive(prender);
        }
    }
}
