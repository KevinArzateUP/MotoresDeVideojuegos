using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManejadorEntradas : MonoBehaviour
{
    public float MovimientoHorizontal()
    {
        #if UNITY_EDITOR
        return Input.GetAxis("Horizontal");
        #elif UNITY_ANDROID
        if (Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            return touch.position.x < Screen.width / 2 ? -1 : 1;
        }
        return 0;
        #endif
    }

    public float MovimientoVertical()
    {
        return Input.GetAxis("Vertical");
    }

    public bool DisparoDetectado()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }
}
