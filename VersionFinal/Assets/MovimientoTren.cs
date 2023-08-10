using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoTren : MonoBehaviour
{
    new Rigidbody rigidbody;
    public float velocidadMovimiento = 10f;
    private Vector3 direccionMovimiento = Vector3.right; // Inicialmente, el tren se moverá hacia la derecha

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        transform.eulerAngles += new Vector3(0, 90, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // Mover el tren en la dirección actual
        transform.position += direccionMovimiento * velocidadMovimiento * Time.deltaTime * 3;
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Vuelta izq":
                // Girar 90 grados hacia la izquierda en el eje Y
                transform.eulerAngles += new Vector3(0, -90, 0);
                // Actualizar la dirección del movimiento hacia adelante (ahora será hacia la izquierda)
                direccionMovimiento = Quaternion.Euler(0, -90, 0) * direccionMovimiento; 
                print("Izquierda");
                break;

            case "Vuelta Der":
                // Girar 90 grados hacia la derecha en el eje Y
                transform.eulerAngles += new Vector3(0, 90, 0);
                // Actualizar la dirección del movimiento hacia adelante (ahora será hacia la derecha)
                direccionMovimiento = Quaternion.Euler(0, 90, 0) * direccionMovimiento; 
                print("Derecha");
                break;

            default:
                break;
        }
    }
}
