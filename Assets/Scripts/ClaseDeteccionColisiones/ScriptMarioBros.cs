using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMarioBros : MonoBehaviour
{
    Vector3 vector1;
    Vector3 vector2;
    Vector3 vectorResultante;

    Vector3 vectorDeContacto;
    Vector3 vectorNormal;

    public Transform posicionOtroObjeto;
    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("EStoy chocando con " + collision.gameObject.name);
        vector1 = collision.transform.position - transform.position;
        vector2 = transform.right;
        Vector3 vectorResultante = Vector3.Cross(vector1, vector2);
        Debug.Log("El producto cruz resultante es: " + vectorResultante);

        if (vectorResultante.z > 1.0f)
            Debug.Log("Choque desde arriba");
        else
            Debug.Log("Choque desde los lados");


        
        //if (collision.contacts[0].point.y > collision.transform.position.y)
        //    Debug.Log("Choque desde arriba");
        //else
        //    Debug.Log("Choque desde los lados");
            

        
        //for (int i = 0; i < collision.contacts.Length; i++)
        //    Debug.Log(collision.contacts[i].point);

        
        //Debug.Log("Colisione con " + collision.gameObject);
        //Debug.Log(Vector3.Cross(transform.position - collision.transform.position, transform.right));

        //if (transform.position.y > collision.transform.position.y)
        //    Debug.Log("Colision desde arriba");
        //else
        //    Debug.Log("Colision desde los lados");
        
        
    }
    */

    private void OnCollisionEnter(Collision collision)
    {
        vector1 = transform.right;
        vector2 = collision.transform.position - transform.position;
        vectorResultante = Vector3.Cross(vector1, vector2);

        vectorDeContacto = collision.contacts[0].point;
        vectorNormal = collision.contacts[0].normal;
        Debug.Log(collision.contacts[0].normal);

        if (vectorNormal.y > collision.transform.position.y)
            Debug.Log("Choque por arriba");
        else
            Debug.Log("Choque por los lados");

    }

    private void Update()
    {
        vector1 = transform.right;
        vector2 = posicionOtroObjeto.position - transform.position;
        vectorResultante = Vector3.Cross(vector1, vector2);


        Debug.DrawRay(transform.position, vector1, Color.green);
        Debug.DrawRay(transform.position, vector2, Color.blue);
        Debug.DrawRay(transform.position, vectorResultante, Color.red);

        Debug.DrawRay(vectorDeContacto, vectorNormal, Color.white);
    }

}
