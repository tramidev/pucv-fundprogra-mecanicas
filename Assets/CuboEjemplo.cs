using UnityEngine;

public class CuboEjemplo : MonoBehaviour
{
    public GameObject texto;

    private void Start()
    {
        texto.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            Debug.Log("Usuario Apreto X");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        texto.SetActive(true);
        Debug.Log("Mensaje Entrada");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Mensaje Salida");
        texto.SetActive(false);
    }
}
