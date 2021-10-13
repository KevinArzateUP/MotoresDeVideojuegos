using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2D : MonoBehaviour
{
    private IPlayerInteractable objetoQueInteractuoConElPlayer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        objetoQueInteractuoConElPlayer = collision.GetComponent<IPlayerInteractable>();
        if (objetoQueInteractuoConElPlayer != null)
            objetoQueInteractuoConElPlayer.InteractuarConPersonaje();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log("Entre al collider");
    }


}



