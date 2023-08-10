using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorPrefab : MonoBehaviour
{
    public GameObject prefabAInstanciar; // Prefab que se generará
    public float intervaloDeGeneracion = 2f; // Intervalo entre generaciones en segundos
    private float tiempoUltimaGeneracion; // Almacena el tiempo de la última generación

    private void Start()
    {
        tiempoUltimaGeneracion = Time.time; // Inicializa el tiempo de la última generación
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Time.time - tiempoUltimaGeneracion >= intervaloDeGeneracion)
        {
            // Instancia el prefab en la posición deseada
            Instantiate(prefabAInstanciar, transform.position, Quaternion.identity);

            // Actualiza el tiempo de la última generación
            tiempoUltimaGeneracion = Time.time;
        }
    }
}