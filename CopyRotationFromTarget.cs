using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyRotationFromTarget : MonoBehaviour {

    public Transform target;

    public Transform source;


    public bool limitY;
    public float minY;
    public float maxY;


    public bool freezeX;
    public bool freezeY;
    public bool freezeZ;

    public bool flipX;
    public bool flipY;
    public bool flipZ;

    public bool useSmooth;
    public float smooth = float.MaxValue;

    // Use this for initialization
    void Start () {
		if (target == null) { target = this.transform; }

	}
	
	// Update is called once per frame
	void Update () {

        if (source != null)
        {
            Vector3 resultEuler = target.rotation.eulerAngles;
            Vector3 sourceEuler = source.rotation.eulerAngles;
            

            if (freezeX == false)
                resultEuler.x = sourceEuler.x;
            if (freezeY == false)
                resultEuler.y = sourceEuler.y;
            if (freezeZ == false)
                resultEuler.z = sourceEuler.z;

            if (flipX == true)
                resultEuler.x = 180 - resultEuler.x;
            if (flipY == true)
                resultEuler.y = resultEuler.y-180;
            if (flipZ == true)
                resultEuler.z = 180 - resultEuler.z;



            if (limitY)
            {
                if (sourceEuler.y < minY)
                {
                    sourceEuler.y = minY;
                }

                if (sourceEuler.y > maxY)
                {
                    sourceEuler.y = maxY;
                }
            }


            Quaternion result;
            if (useSmooth)
                result = Quaternion.Lerp(target.rotation, Quaternion.Euler(resultEuler), Time.deltaTime * smooth);
            else
                result = Quaternion.Euler(resultEuler);





            target.rotation = result;

        }
	}
}
