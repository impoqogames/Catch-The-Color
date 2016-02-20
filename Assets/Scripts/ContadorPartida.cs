﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ContadorPartida : MonoBehaviour
{

    public Text Cubos_Lanzados;
    public Text Cubos_Destruidos;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Cubos_Lanzados.text = "Cubos totales: " + GameManager.cubosLanzados;
        Cubos_Destruidos.text = "Cubos eliminados: " + GameManager.cubosDestruidos;
    }
}