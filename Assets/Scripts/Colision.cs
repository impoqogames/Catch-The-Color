﻿using UnityEngine;
using System.Collections;

public class Colision : MonoBehaviour
{
    public GameObject explosion;
    public GameObject esfera = new GameObject();
    public GameObject suelo = new GameObject();

    void OnCollisionEnter(Collision col)
    {
        Color colorEsferaActual = esfera.GetComponent<Renderer>().material.color;

        if (colorEsferaActual == Color.white)
        {
            switch (col.gameObject.tag)
            {
                case "Amarillo":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                    esfera.tag = "b_Amarilla";
                    esfera.GetComponent<Renderer>().material.color = Color.yellow;
                    break;
                case "Azul":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                    esfera.tag = "b_Azul";
                    esfera.GetComponent<Renderer>().material.color = Color.blue;
                    break;
                case "Rojo":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                    esfera.tag = "b_Roja";
                    esfera.GetComponent<Renderer>().material.color = Color.red;
                    break;
                case "Fucsia":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                    esfera.tag = "b_Fucsia";
                    esfera.GetComponent<Renderer>().material.color = Color.magenta;
                    break;
                case "Blanco":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                    esfera.tag = "b_Blanca";
                    esfera.GetComponent<Renderer>().material.color = Color.white;
                    break;
                case "Verde":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                    esfera.tag = "b_Verde";
                    esfera.GetComponent<Renderer>().material.color = Color.green;
                    break;
            }
        }
        else {
            if (col.gameObject.tag == "Amarillo" && esfera.tag == "b_Amarilla")
            {
                Destroy(col.gameObject);
                Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                GameManager.cubosDestruidos++;
            }
            if (col.gameObject.tag == "Azul" && esfera.tag == "b_Azul")
            {
                Destroy(col.gameObject);
                Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                GameManager.cubosDestruidos++;
            }
            if (col.gameObject.tag == "Verde" && esfera.tag == "b_Verde")
            {
                Destroy(col.gameObject);
                Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                GameManager.cubosDestruidos++;
            }
            if (col.gameObject.tag == "Fucsia" && esfera.tag == "b_Fucsia")
            {
                Destroy(col.gameObject);
                Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                GameManager.cubosDestruidos++;
            }
            if (col.gameObject.tag == "Rojo" && esfera.tag == "b_Roja")
            {
                Destroy(col.gameObject);
                Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                GameManager.cubosDestruidos++;
            }
            if (col.gameObject.tag == "Blanco")
            {
                Destroy(col.gameObject);
                Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                esfera.GetComponent<Renderer>().material.color = Color.white;
                GameManager.cubosDestruidos++;
            }
        }
    }
}
