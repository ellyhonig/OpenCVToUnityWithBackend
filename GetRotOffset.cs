using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRotOffset : MonoBehaviour {

	public Transform target;



	public Transform masterCenterJoint;
	public Transform masterShoulderJoint;
	public Transform masterHipsJoint;

	public Transform slaveCenterJoint;
	public Transform slaveShoulderJoint;
	public Transform slaveHipsJoint;


	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

		Vector3 aaa = masterCenterJoint.position - masterShoulderJoint.position ;
		Vector3 ccc = masterCenterJoint.position- masterHipsJoint.position ;

		Vector3.OrthoNormalize (ref aaa, ref ccc);

		//Debug.Log ("aaa: "+ aaa);
		//Debug.Log ("ccc: " +ccc);


		Vector3 bbb = slaveCenterJoint.position- slaveShoulderJoint.position;
		Vector3 ddd = slaveCenterJoint.position- slaveHipsJoint.position;

		Vector3.OrthoNormalize (ref bbb, ref  ddd);



		Quaternion q1 = FindQuat (ddd, ccc);
		Quaternion q2 = FindQuat (bbb, aaa);



		//Debug.Log ((q2*q1).eulerAngles);





		Debug.Log (FindQuat (slaveCenterJoint.forward, masterCenterJoint.forward).eulerAngles);
	}


	public Vector3 offsetBetweenVectors(Vector3 a, Vector3 b){
		
		return (transform.rotation * target.rotation).eulerAngles;
	}


	public Quaternion FindQuat(Vector3 a , Vector3 b){
		
		return Quaternion.FromToRotation (b,a);
	}




}
