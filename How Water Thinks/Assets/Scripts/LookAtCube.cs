using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCube : MonoBehaviour {

	public GameObject membraneCube;
    private float speed = 10.0f;
	private Vector3 membraneTransform;

	// Use this for initialization
	void Start () {

		membraneCube = GameObject.FindGameObjectWithTag ("Boxes");

		Debug.Log ("Look at = " + membraneCube.name);

		membraneTransform = membraneCube.transform.position;
		transform.LookAt (membraneTransform);
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.RotateAround(membraneCube.transform.position, Vector3.up, speed*Time.deltaTime);
		
	}
}
