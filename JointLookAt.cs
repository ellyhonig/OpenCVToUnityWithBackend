using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointLookAt : MonoBehaviour {

    public Transform target;

    public bool limitLookAtIfNotMoving;
    private Vector3 lastPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        /*
        if (limitLookAtIfNotMoving)
        {
            if (transform.position != lastPosition)
            {
                transform.LookAt(target);
            }
            else
            {
                transform.rotation = Quaternion.identity;
            }

            lastPosition = transform.position;
        }
        else*/
        {
            transform.LookAt(target);
        }
        
    }
}
