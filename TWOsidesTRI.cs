using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TWOsidesTRI : MonoBehaviour
{
    public float toR;
    public float toL;
    public Transform targetL;
    public Transform targetR;




    void Update()

    {
        toL = Vector3.Distance(transform.position, targetL.position);
        toR = Vector3.Distance(transform.position, targetR.position);
    }
}



