using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public int cantidad = 0;
    public GameObject canvasGameOver;
    public Text textoInventario;
    void Update()
    {
        textoInventario.text = "Tesoro recuperado: " + cantidad.ToString();
        if (cantidad >= 10)
        {
            canvasGameOver.SetActive(true);
        }
    }
}


