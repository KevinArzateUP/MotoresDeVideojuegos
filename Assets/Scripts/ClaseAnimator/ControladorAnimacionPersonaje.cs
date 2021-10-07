using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAnimacionPersonaje : MonoBehaviour
{
    public Animator animatorPersonaje;

    public AudioSource fuenteAudio;
    public AudioClip sonidoPasos;

    private bool hasWeapon;

    private void Start()
    {
        hasWeapon = false;
    }

    private void Update()
    {
        animatorPersonaje.SetFloat("JoystickAxis", Input.GetAxis("Vertical"));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animatorPersonaje.SetTrigger("Attack");
            animatorPersonaje.SetLayerWeight(1, 1f);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            animatorPersonaje.SetTrigger("Died");
            animatorPersonaje.SetLayerWeight(1, 0f);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            hasWeapon = !hasWeapon;
            animatorPersonaje.SetBool("isEquiped", hasWeapon);
            animatorPersonaje.SetLayerWeight(1, hasWeapon ? 1f : 0f);

        }
            

        

        animatorPersonaje.speed = 1f + Input.GetAxis("Horizontal");
    }

    public void Pisada()
    {
        Debug.Log("El personaje piso el suelo");
        fuenteAudio.PlayOneShot(sonidoPasos);
    }
}
