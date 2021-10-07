using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMovement : MonoBehaviour
{
    public Transform transformToFollow;
    public Vector3 positionToFollow;
    public float distance;
    public float speedMovement;

    private Vector3 vectorToTarget;

    void Update()
    {
        vectorToTarget = transform.position - transformToFollow.position;

        this.transform.SetPositionAndRotation
            (
                Vector3.MoveTowards
                (
                    transform.position + ( vectorToTarget * (distance - Mathf.Clamp( vectorToTarget.magnitude, 0, distance))),
                    transformToFollow.position - (positionToFollow),
                    speedMovement * Time.deltaTime
                ),
                Quaternion.LookRotation(-vectorToTarget)
            );
    }
}
