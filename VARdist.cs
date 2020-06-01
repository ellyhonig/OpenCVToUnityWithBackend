using UnityEngine;
using System.Collections;

public class VARdist : MonoBehaviour
{

    public float dist;
    public Transform target;




    void Update()

    {
        dist = Vector3.Distance(transform.position, target.position);
    }
}