using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCube : MonoBehaviour {

	GameObject membraneCube;
	Transform membraneTransform;

	// Use this for initialization
	void Start () {

		membraneCube = GameObject.FindGameObjectWithTag ("Boxes");

		Debug.Log ("Look at = " + membraneCube.name);

		membraneTransform = membraneCube.transform;
		transform.LookAt (membraneTransform);
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.LookAt (membraneTransform);
		
	}
}
