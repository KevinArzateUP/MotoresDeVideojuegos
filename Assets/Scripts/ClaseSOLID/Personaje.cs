using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public float speedMove;
    public InstanciaMejorada objectPooling;
    private GameObject objetoSolicitado;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            objetoSolicitado = objectPooling.PedirObjetoDisponible();
            objetoSolicitado.transform.SetPositionAndRotation(this.transform.position, this.transform.rotation);
            objetoSolicitado.SetActive(true);
            
        }
    }
}
