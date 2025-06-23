using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlataformaColor : MonoBehaviour
{
    public int colorActual = 0;
    private int colorMaximo = 3;
    
    public Sprite spriteVerde;
    public Sprite spriteRojo;
    public Sprite spriteAmarillo;
    public Sprite spriteRosado;

    private SpriteRenderer spriteRenderer;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        int colorRandom = Random.Range(0, colorMaximo+1);
        colorActual = colorRandom;
        SetColor(colorActual);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        colorActual++;
        if (colorActual > colorMaximo)
        {
            colorActual = 0;
        }

        SetColor(colorActual);
    }


    private void SetColor(int color)
    {
        Sprite selectedSprite = spriteVerde;
        switch (color)
        {
            case 0:
                selectedSprite = spriteVerde;
                break;
            case 1:
                selectedSprite = spriteRojo;
                break;
            case 2:
                selectedSprite = spriteAmarillo;
                break;
            case 3:
                selectedSprite = spriteRosado;
                break;
            default:
                selectedSprite = spriteVerde;
                break;
        }
        spriteRenderer.sprite = selectedSprite;
    }
}
