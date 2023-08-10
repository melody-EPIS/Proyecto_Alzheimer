using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambio : MonoBehaviour
{
    // Start is called before the first frame update
    string dir="";
    
    void Start(){
        
        if(gameObject.tag=="Vuelta izq"){
            dir="Izq";
        }else if (gameObject.tag=="Vuelta Der"){
            dir="Der";
        }else{
            dir="Izq";
        }
    }

    private void OnMouseDown(){
        
        string currentTag = gameObject.tag;
        if (currentTag == "Vuelta izq" || currentTag == "Vuelta Der"){
            gameObject.tag = "Recto";
        }else if (currentTag == "Recto" && dir=="Izq"){
            gameObject.tag = "Vuelta izq";
        }else if (currentTag == "Recto" && dir=="Der"){
            gameObject.tag = "Vuelta Der";
        }
        //Verifica cada subobjeto de un objeto compuesto 
        RecorrerDescendientes(transform);
    }
    
    private void RecorrerDescendientes(Transform parent)
    {
        // Verificar si el tag del objeto actual no es "Vuelta izq" ni "Vuelta Der"
        if (parent.tag != "Vuelta izq" && parent.tag != "Vuelta Der" && parent.tag != "Recto")
        {
            // Obtener el componente MeshRenderer del objeto actual
            MeshRenderer meshRenderer = parent.GetComponent<MeshRenderer>();

            // Verificar si el objeto actual tiene un MeshRenderer
            if (meshRenderer != null)
            {
                // Invertir el estado actual del MeshRenderer del objeto actual
                meshRenderer.enabled = !meshRenderer.enabled;
            }
        }

        // Recorrer todos los hijos del objeto actual
        foreach (Transform child in parent)
        {
            // Recursivamente llamar a la función para los hijos de los hijos
            RecorrerDescendientes(child);
        }
    }

    void Update()
    {
        
    }
}