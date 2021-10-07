using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour, IMove
{
    private void Update()
    {
        Move();
    }

    public void Move()
    {
        transform.position += transform.forward * Time.deltaTime;
    }
}
