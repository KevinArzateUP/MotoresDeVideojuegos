using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorAleatorio : MonoBehaviour
{
    public Transform[] posicionesAleatorias;
    public InstanciaMejorada objectPooling;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            ColocarObjetoAleatorio();
    }

    public void ColocarObjetoAleatorio()
    {
        objectPooling.PedirObjetoDisponible(posicionesAleatorias
            [Random.Range(0, posicionesAleatorias.Length)].position);

        /*objectPooling.PedirObjetoDisponible().transform.position 
            = new Vector3(Random.Range(-5f,5f), 0, Random.Range(-5f,5f));*/

        //objectPooling.PedirObjetoDisponible(Vector3.one);
    }
}
