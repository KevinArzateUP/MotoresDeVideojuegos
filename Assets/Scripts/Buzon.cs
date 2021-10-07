using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buzon : MonoBehaviour, IDamagable
{
    public float tiempoDePoder = 10;
    public int ataquesMaximos;
    private int ataquesEfectuados;

    public void PoderAdquirido()
    {
        ataquesEfectuados = 0;
        StartCoroutine(RoutinePoder());
    }

    public void ReceiveDamage()
    {

        this.gameObject.SetActive(false);
    } 


    public void Atacar()
    {
        ataquesEfectuados++;
        if (ataquesEfectuados>ataquesMaximos)
        {
            this.StopAllCoroutines();
            DesactivarPoder();
        }
    }

    public void DesactivarPoder()
    {

    }

    IEnumerator RoutinePoder()
    {
        yield return new WaitForSeconds(tiempoDePoder);
        DesactivarPoder();
    }
}

