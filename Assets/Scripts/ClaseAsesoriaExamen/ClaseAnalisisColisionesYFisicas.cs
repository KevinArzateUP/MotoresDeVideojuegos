using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaseAnalisisColisionesYFisicas : MonoBehaviour
{
    public float radioSphereCast;
    public BoxCollider box_Collider;

    [SerializeField]
    float tiempoDeEspera = 0.5f;
    float tiempoTranscurrido;

    // Start is called before the first frame update
    void Start()
    {
        tiempoTranscurrido = 0;
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Ray raySphere = new Ray(Vector3.zero, Vector3.one);
            RaycastHit[] raycastInfo;
            raycastInfo = Physics.SphereCastAll(raySphere, radioSphereCast);
            if (raycastInfo.Length > 0)
            {
                for (int i = 0; i < raycastInfo.Length; i++)
                {
                    Rigidbody rb = raycastInfo[i].collider.GetComponent<Rigidbody>();
                    if (rb!=null)
                        rb.AddExplosionForce(15f, Vector3.zero, radioSphereCast, 1f, ForceMode.Impulse);
//                    Debug.Log(raycastInfo[i].collider.name + " esta a " + raycastInfo[i].distance + " unidades de distancia");
                }
                    
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
