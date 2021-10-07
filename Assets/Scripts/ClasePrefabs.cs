using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClasePrefabs : MonoBehaviour
{
    public GameObject referenciaPrefab;
    public Transform transformCamara;

    public int cantidadDeObjetos;
    public List<GameObject> objetosCreados;

    private GameObject objetoActivo;
    public Vector3 posicionInicialMouse;
    private Vector3 deltaMouse;
    void Start()
    {
        objetosCreados = new List<GameObject>();
        for (int i = 0; i < cantidadDeObjetos; i++)
        {
            objetosCreados.Add(Instantiate(referenciaPrefab));
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            for (int i = 0; i < objetosCreados.Count;i++)
            {
                if (objetosCreados[i].activeInHierarchy==false)
                {
                    objetosCreados[i].transform.SetPositionAndRotation
                        (transformCamara.position + transform.forward, transform.rotation);
                    objetoActivo = objetosCreados[i];
                    objetoActivo.SetActive(true);
                    posicionInicialMouse = Input.mousePosition;
                    break;
                }
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            deltaMouse = Input.mousePosition - posicionInicialMouse;
            deltaMouse = deltaMouse.normalized * 5f;
            deltaMouse.z = 10f;
            Debug.Log(deltaMouse);
            objetoActivo.GetComponent<Rigidbody>().AddForce(deltaMouse, ForceMode.Impulse);
            objetoActivo = null;
        }
    }
}
