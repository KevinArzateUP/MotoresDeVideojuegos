using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class InteligenciaArtificial : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform puntoDestino;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(puntoDestino.position);
    }
}
