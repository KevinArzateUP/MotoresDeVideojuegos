using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Vector3 vectorMovimiento;
    float velocidadFinal = 0;
    
    public Rigidbody rb;
    // Update is called once per frame
    private void Start()
    {
        //vectorMovimiento = Vector3.zero;
    }

    void Update()
    {
        velocidadFinal = Time.deltaTime * speed;
        vectorMovimiento.x = velocidadFinal * Input.GetAxis("Horizontal");
        vectorMovimiento.z = velocidadFinal * Input.GetAxis("Vertical");
        //transform.position += vectorMovimiento;

        rb.MovePosition(transform.position + vectorMovimiento);
    }

    
}
