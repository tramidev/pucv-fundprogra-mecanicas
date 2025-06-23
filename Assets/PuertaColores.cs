using TMPro;
using UnityEngine;

public class PuertaColores : MonoBehaviour
{
    public PlataformaColor[] plataformas;
    public TextMeshPro textoHint;
    public Transform puerta;

    public int colorParaGanar;
    private int colorMaximo = 3;

    public int coloresCorrectos;
    
    public Vector3 posicionFinal;

    private bool puertaCerrada = true;
    
    void Start()
    {
        colorParaGanar = Random.Range(0, colorMaximo+1);
        int numColores = ObtenerColoresCorrectos();
        ActualizarContador(numColores);
    }

    private void ActualizarContador(int numeroColoresACambiar)
    {
        if (coloresCorrectos != numeroColoresACambiar)
        {
            coloresCorrectos = numeroColoresACambiar;
            textoHint.text = numeroColoresACambiar+"/"+plataformas.Length;
        }
    }

    private int ObtenerColoresCorrectos()
    {
        int coloresCorrectos = 0;
        for (int i = 0; i < plataformas.Length; i++)
        {
            int colorPlataformaActual  = plataformas[i].colorActual;
            if (colorPlataformaActual == colorParaGanar)
            {
                coloresCorrectos++;
            }
        }
        return coloresCorrectos;
    }

    // Update is called once per frame
    void Update()
    {
        int numColores = ObtenerColoresCorrectos();
        ActualizarContador(numColores);
        if (puertaCerrada && numColores >= plataformas.Length)
        {
            AbrirPuerta();
        }
        else if (!puertaCerrada && numColores < plataformas.Length)
        {
            CerrarPuerta();
        }
    }

    public void AbrirPuerta()
    {
        puertaCerrada = false;
        puerta.position = puerta.position + posicionFinal;
    }
    
    public void CerrarPuerta()
    {
        puertaCerrada = true;
        puerta.position = puerta.position - posicionFinal;
    }
    
    
}
