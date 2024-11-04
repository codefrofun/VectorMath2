using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorProject : MonoBehaviour
{
    public GameObject Eyes;
    public GameObject ZeroPoint;
    public float colorChange = 2.0f;

    private void Start()
    {
        transform.position = Vector3.forward;
    }

    void OnDrawGizmos()
    {
        if (Eyes == null && ZeroPoint == null)
            return;
        Vector3 directionToLook = Eyes.transform.position - ZeroPoint.transform.position;
        float distance = directionToLook.magnitude;

        directionToLook.Normalize();
        directionToLook = directionToLook * 2.0f;

        Vector3 directionTo = (Eyes.transform.position - ZeroPoint.transform.position).normalized;
        ZeroPoint.transform.up = directionTo;

        if (distance < colorChange)
        {
            Gizmos.color = Color.green;
        }
        else
        {
            Gizmos.color = Color.red;
        }


        Gizmos.DrawLine(Eyes.transform.position.normalized , ZeroPoint.transform.position);
    }
}
