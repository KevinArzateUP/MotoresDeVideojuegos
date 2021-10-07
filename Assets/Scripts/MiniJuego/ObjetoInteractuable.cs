using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoInteractuable : MonoBehaviour
{


    public EnumTipoObjeto tipoObjeto;

    public virtual void JugadorDentroRango()
    {
        Debug.Log("El jugador entro " + this.name);
        ConfiguracionAudio.instance.ReproducirSonido(tipoObjeto);
    }

    public virtual void JugadorFueraRango()
    {
        Debug.Log("El jugador salio " + this.name);
    }
}



public enum EnumTipoObjeto
{
    cubo,
    esfera,
    capsula
}