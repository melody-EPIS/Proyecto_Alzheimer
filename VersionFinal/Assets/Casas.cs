using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class Casas : MonoBehaviour
{

    public GameObject CASA;
    public int numeroColor;
    private string nameColor = "";

    // Start is called before the first frame update
    void Start()
    {

        definirColor();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void definirColor()
    {

        switch (numeroColor)
        {
            case 1:
                CASA.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
                nameColor = "verde";
                break;
            case 2:
                CASA.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                nameColor = "rojo";
                break;
            case 3:
                CASA.GetComponent<Renderer>().material.SetColor("_Color", Color.cyan);
                nameColor = "cyan";
                break;
            case 4:
                CASA.GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
                nameColor = "azul";
                break;

        }
        
    }
}
