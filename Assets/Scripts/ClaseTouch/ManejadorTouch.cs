using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManejadorTouch : MonoBehaviour
{
    public InstanciaMejorada instanciaMejorada;
    public Transform posicionSpawn;
    private PrefabEsfera referenciaActiva;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.touchCount > 0)
        //{
        //    Touch touchActual = Input.GetTouch(0);
            
        //    if (touchActual.phase.Equals(TouchPhase.Began))
        //    {
        //        referenciaActiva = instanciaMejorada.PedirObjetoDisponible();
        //        if (referenciaActiva!=null)
        //        {
        //            referenciaActiva.ActivarEsteObjeto(posicionSpawn.position);

        //        }
        //    }


        //    if (touchActual.phase.Equals(TouchPhase.Moved))
        //    {
        //        if (referenciaActiva != null)
        //            referenciaActiva.LanzarEsteObjeto(touchActual.deltaPosition * 0.01f);
        //    }

        //    //if (referenciaActiva != null)
        //    //    referenciaActiva.LanzarEsteObjeto(touchActual.tapCount);


        //}
    }
}
