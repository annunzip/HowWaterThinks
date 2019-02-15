using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddVelocity : MonoBehaviour {

	Rigidbody rb;
	public float velocityMultiplier = 0.0f;
	public float angularVelocityMultiplier = 0.0f;
	Vector3 atomVelocity;
	public float temperatureMultiplier = 0.5f;

	// Use this for initialization
	void Start () {

		// Calculate a random velocity
		atomVelocity = Vector3.forward * (Random.value - 0.05f) + Vector3.up * (Random.value - 0.05f) + Vector3.right * (Random.value - 0.05f);

		rb = GetComponent<Rigidbody> ();
		rb.velocity += atomVelocity * velocityMultiplier;
		rb.angularVelocity += atomVelocity * angularVelocityMultiplier;
		
	}
	
	// Update is called once per frame
	void Update () {

		atomVelocity = Vector3.forward * (Random.value - 0.05f) + Vector3.up * (Random.value - 0.05f) + Vector3.right * (Random.value - 0.05f);
		rb.velocity += atomVelocity * velocityMultiplier * temperatureMultiplier;
		rb.angularVelocity += atomVelocity * angularVelocityMultiplier;
		
	}
}
