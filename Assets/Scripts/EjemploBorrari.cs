using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploBorrari : MonoBehaviour
{
    public GameObject objetoPrefab;
    public Transform[] posicionesSpawn;
    public List<GameObject> objetosCreados;

    private void Start()
    {
        objetosCreados = new List<GameObject>();
        CrearObjetos();   
    }

    private void OnTriggerEnter(Collider other)
    {
        DesactivarObjetos();
    }

    public void CrearObjetos()
    {
        for (int i = 0; i < posicionesSpawn.Length;i++)
        {
            // PEDIRO OBJETO DEL OBJECT POOLING
            objetosCreados.Add(Instantiate(objetoPrefab, posicionesSpawn[i].position, Quaternion.identity));
        }
    }

    public void DesactivarObjetos()
    {
        for (int i = 0; i < objetosCreados.Count; i++)
        {
            objetosCreados[i].SetActive(false);
        }
    }
}
