using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ConfiguracionAudio : MonoBehaviour
{
    public static ConfiguracionAudio instance;

    public AudioMixer mixerMusicaFondo;

    public AudioClip sonidoAReproducir;
    public AudioSource fuenteDeSonido;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        
    }

    public void ColocarVolumen(float cantidad)
    {
        mixerMusicaFondo.SetFloat("VolumenMusicaFondo", Mathf.Lerp( -80,20, cantidad) );
    }

    public void ColocarSFX(float cantidad)
    {
        mixerMusicaFondo.SetFloat("VolumenMusicaSFX", Mathf.Lerp(-80, 20, cantidad));
    }

    public void ReproducirSonido(EnumTipoObjeto tipoDeObjeto)
    {
        /*
        fuenteDeSonido.clip = sonidoAReproducir;
        fuenteDeSonido.loop = false;
        fuenteDeSonido.Play();*/
        Debug.Log("Un objeto tipo: " + tipoDeObjeto + " me pidio reproducir audio");

        switch (tipoDeObjeto)
        {
            case EnumTipoObjeto.capsula:
                Debug.Log("Aqui va una capsuila");
            break;


        }

        fuenteDeSonido.PlayOneShot(sonidoAReproducir);
    }
}
