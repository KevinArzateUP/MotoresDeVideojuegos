using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public Rigidbody rb;
    public float velocidad;

    private void OnEnable()
    {
        rb.AddForce(transform.forward * velocidad, ForceMode.Impulse);
    }//9.8N


    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }

    /*
    public float velocidadBala;
    public float tiempoDeVida;

    private void OnCollisionEnter(Collision collision)
    {
        this.StopAllCoroutines();
        IDamagable objetoDaniable;
        objetoDaniable = collision.gameObject.GetComponent<IDamagable>();
        if (objetoDaniable!=null)
            objetoDaniable.ReceiveDamage();


        gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        StartCoroutine(RoutineDesactivar());
    }
    
    
    void Update()
    {
        
            
        transform.position += velocidadBala * Time.deltaTime * Vector3.forward;
    }

    IEnumerator RoutineDesactivar()
    {
        yield return new WaitForSeconds(tiempoDeVida);
        gameObject.SetActive(false);
    }*/
}
