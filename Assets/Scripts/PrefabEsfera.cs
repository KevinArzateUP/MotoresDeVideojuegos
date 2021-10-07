using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabEsfera : MonoBehaviour
{
    public bool estaActivo { get { return gameObject.activeInHierarchy; } }

    public Rigidbody rigidbody;

    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        rigidbody.velocity = Vector3.zero;
    }

    public void ActivarEsteObjeto(Vector3 posicionParaMover)
    {
        this.transform.position = posicionParaMover;
        gameObject.SetActive(true);
        
    }

    public void LanzarEsteObjeto(Vector3 vectorDeLanzamiento)
    {
        rigidbody.AddForce(vectorDeLanzamiento * 15f, ForceMode.Impulse);
    }

    public void LanzarEsteObjeto(int intensidad)
    {
        rigidbody.AddForce(Vector3.up * intensidad, ForceMode.Impulse);
    }
}
