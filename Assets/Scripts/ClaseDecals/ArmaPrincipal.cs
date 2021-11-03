using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaPrincipal : MonoBehaviour
{
    public LineRenderer _lineRenderer;
    public GameObject prefabDecal;

    public Ray rayo;
    public RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rayo = new Ray(transform.position, transform.forward);
        _lineRenderer.SetPosition(0, transform.position);

        if (Physics.Raycast(rayo, out hit))
        {
            
            _lineRenderer.SetPosition(1, hit.point);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                CreateDecal(hit.point, hit.normal);
            }
        }
        else
            _lineRenderer.SetPosition(1, transform.forward * 100);
    }

    public void CreateDecal(Vector3 point, Vector3 normal)
    {
        GameObject referencia = Instantiate(prefabDecal, point, Quaternion.identity);
        referencia.transform.forward = -normal;


    }
}
