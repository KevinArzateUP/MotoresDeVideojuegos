using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoHaciaUnPunto : MonoBehaviour
{
    public Transform puntoDestino;
    public float velocidad;

    private Vector3 posicionInicial;
    private float posicionInterpolacion;

    public Transform[] puntosAPatrullar;

    void Start()
    {
        
    }

    private void OnEnable()
    {
        if (puntoDestino==null)
        {
            puntosAPatrullar = FindObjectOfType<GeneradorAleatorio>().posicionesAleatorias;
            
        }
            

        StartCoroutine(RoutineMovimiento());
        Debug.Log(puntoDestino);
        this.transform.LookAt(puntoDestino);
    }

    
    void Update()
    {
        /*if (Vector3.Distance(transform.position,puntoDestino.position) > 0.1f)
            transform.Translate(transform.forward * Time.deltaTime);*/
    }

    IEnumerator RoutineMovimiento()
    {
        
        for (int i = 0; i < puntosAPatrullar.Length;i++)
        {
            puntoDestino = puntosAPatrullar[i];
            posicionInterpolacion = 0;
            posicionInicial = transform.position;
            while (posicionInterpolacion < 1)
            {
                posicionInterpolacion += Time.deltaTime * velocidad;


                transform.position =
                    Vector3.Lerp(
                        posicionInicial,
                        puntoDestino.position,
                        posicionInterpolacion);
                yield return new WaitForEndOfFrame();
            }
        }

    }
}
