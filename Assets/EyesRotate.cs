using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyesRotate : MonoBehaviour
{
    public GameObject Eyes;
    public GameObject ZeroPoint;
    public float colorChange = 1.5f;

    private void Start()
    {
        transform.position = Vector3.forward;
    }

    void OnDrawGizmos()
    {
       // Debug.Log($"Starting my ondrawgizmos, Zero point is {ZeroPoint} Eyes is {Eyes}, about to do if statement checking for  nulls {ZeroPoint == null && Eyes == null}");
        if (ZeroPoint == null && Eyes == null) {
            //Debug.Log("It's null so stop");
            return;
        }
        Vector3 directionToLook = ZeroPoint.transform.position - Eyes.transform.position;
        float distance = directionToLook.magnitude;

        //Debug.Log("It's null so stop");
        directionToLook.Normalize();
        directionToLook = directionToLook * 2.0f;

        Vector3 directionTo = (ZeroPoint.transform.position - Eyes.transform.position).normalized;
        
        Eyes.transform.forward = directionTo;

        if (distance < colorChange)
        {
            Gizmos.color = Color.green;
        }
        else
        {
            Gizmos.color = Color.red;
        }


        Gizmos.DrawLine(ZeroPoint.transform.position.normalized, Eyes.transform.position);
    }
}
