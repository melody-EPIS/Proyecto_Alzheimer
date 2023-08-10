using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class CambiarColor : MonoBehaviour
{

    public GameObject trencito;
    int numeroColor = 0;
    private string nameColor = "";

    // Start is called before the first frame update
    void Start()
    {

        cambiarColor();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void cambiarColor()
    {
        
        numeroColor = Random.Range(1, 5);

        switch (numeroColor)
        {
            case 1:
                trencito.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
                nameColor = "verde";
                break;
            case 2:
                trencito.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                nameColor = "rojo";
                break;
            case 3:
                trencito.GetComponent<Renderer>().material.SetColor("_Color", Color.cyan);
                nameColor = "cyan";
                break;
            case 4:
                trencito.GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
                nameColor = "azul";
                break;

        }
        
    }
}
