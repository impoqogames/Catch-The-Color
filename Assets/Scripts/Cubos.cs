﻿using UnityEngine;
using System.Collections;

public class Cubos : MonoBehaviour
{

    public GameObject[] cubos = new GameObject[6];
    public float minTiempoEntreCubos = 1.0f, maxTiempoEntreCubos = 1.5f;
    public float minX = -24.0f, maxX = 24.0f;
    public float minZ = -11.0f, maxZ = 11.0f;
    public float y = 0.5f;

    private bool enableStones = true;
    private Rigidbody rigidbody;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(CubosEnJuego());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator CubosEnJuego()
    {
        // Initial delay
        yield return new WaitForSeconds(2.0f);

        while (enableStones)
        {

            GameObject cubo = (GameObject)Instantiate(cubos[Random.Range(0, cubos.Length)]);
            cubo.transform.position = new Vector3(Random.Range(minX, maxX), y, Random.Range(minZ, maxZ));
            cubo.transform.rotation = Random.rotation;

            rigidbody = cubo.GetComponent<Rigidbody>();

            GameManager.cubosLanzados++;

            yield return new WaitForSeconds(Random.Range(minTiempoEntreCubos, maxTiempoEntreCubos));

        }

    }

}
