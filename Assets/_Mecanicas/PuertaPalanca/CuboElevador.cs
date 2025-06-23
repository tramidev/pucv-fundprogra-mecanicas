using UnityEngine;

public class CuboElevador : MonoBehaviour
{
    public GameObject texto;
    public Vector3 puntoFinal;
    private bool puertaAbierta;
    private bool playerInteractuando;
    public bool actuarComoPuerta = true;

    private void Start()
    {
        PrenderTexto(false);
        if (!actuarComoPuerta)
        {
            BoxCollider2D boxCollider2D = GetComponent<BoxCollider2D>();
            boxCollider2D.enabled = false;
        }
    }

    private void Update()
    {
        if(!actuarComoPuerta) return;
        
        if (Input.GetKeyUp(KeyCode.F) && playerInteractuando && actuarComoPuerta)
        {
            Debug.Log("Usuario Presionó tecla F");
            
            AbrirPuerta();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PrenderTexto(true);
        Debug.Log("Mensaje Entrada");
        playerInteractuando = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Mensaje Salida");
        PrenderTexto(false);
        playerInteractuando = false;
    }

    public void AbrirPuerta()
    {
        if (!puertaAbierta)
        {
            PrenderTexto(false);
            puertaAbierta = true;
            transform.position = transform.position + puntoFinal;
        }
    }

    public void CerrarPuerta()
    {
        if (puertaAbierta)
        {
            puertaAbierta = false;
            PrenderTexto(false);
            transform.position = transform.position - puntoFinal;
        }
    }

    void PrenderTexto(bool prender)
    {
        if (!puertaAbierta)
        {
            //detectar si texto no esta seteado
            if (texto != null)
            {
                texto.SetActive(prender);
            }
        }
    }
}
