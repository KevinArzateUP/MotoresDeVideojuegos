using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciaMejorada : MonoBehaviour
{
    public GameObject referenciaPrefab;
    public int cantidadDeObjetosIniciales;
    public List<GameObject> objetosCreados;

    private GameObject objetoNuevoCreado;

    void Start()
    {
        objetosCreados = new List<GameObject>();
        for (int i = 0; i < cantidadDeObjetosIniciales; i++)
        {
            objetoNuevoCreado = Instantiate(referenciaPrefab);
            objetosCreados.Add(objetoNuevoCreado);
            objetoNuevoCreado.SetActive(false);
            
        }
    }

    public GameObject PedirObjetoDisponible(Vector3 posicionInicial = new Vector3())
    {


        for (int i = 0; i < objetosCreados.Count;i++)
        {
            if (!objetosCreados[i].activeInHierarchy)
            {
                if (posicionInicial.magnitude != 0)
                {
                    objetosCreados[i].transform.position = posicionInicial;
                }
                //objetosCreados[i].SetActive(true);
                return objetosCreados[i];
            }
        }

        return null;
    }    

    

}
