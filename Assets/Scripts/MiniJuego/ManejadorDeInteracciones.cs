using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManejadorDeInteracciones : MonoBehaviour
{
    public ObjetoInteractuable objetoActivo;
    private bool dentroDeUnObjetoInteractuable;
    

    private void OnTriggerEnter(Collider other)
    {
        objetoActivo = other.GetComponent<ObjetoInteractuable>();

        //other.GetComponent<ObjetoInteractuable>().JugadorDentroRango();
    }

    private void OnTriggerExit(Collider other)
    {
        objetoActivo.JugadorFueraRango();
        objetoActivo = null;
        //other.GetComponent<ObjetoInteractuable>().JugadorFueraRango();
    }

    private void Update()
    {
        if (objetoActivo != null)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                objetoActivo.JugadorDentroRango();
            }
        }
    }
}
