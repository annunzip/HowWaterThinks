using UnityEngine;
using System.Collections;

public class FirstPersonCamera : MonoBehaviour {

	void KeyboardMovement(){

		var movementAmount = 0.15f;
		var movementVector = new Vector3(0f, 0f, 0f);
		bool hMoveLeft = Input.GetKey (KeyCode.LeftArrow);
		bool hMoveRight = Input.GetKey (KeyCode.RightArrow);
		bool vMoveDown = Input.GetKey (KeyCode.DownArrow);
		bool vMoveUp = Input.GetKey (KeyCode.UpArrow);
		bool zoomIn = Input.GetKey (KeyCode.Equals);
		bool zoomOut = Input.GetKey (KeyCode.Minus);


		// left arrow
		if (hMoveLeft) movementVector.x = -movementAmount;
		// right arrow
		if (hMoveRight) movementVector.x = movementAmount;
		// up arrow
		if (vMoveUp) movementVector.y = movementAmount;
		// down arrow
		if (vMoveDown) movementVector.y = -movementAmount;
		// zoom in
		if (zoomIn) movementVector.z = movementAmount;
		// zoom out
		if (zoomOut) movementVector.z = -movementAmount;
		// Using Translate allows you to move while taking the current rotation into consideration
		transform.Translate(movementVector);

	}
	
	// Update is called once per frame
	void Update () {

		KeyboardMovement();
	
	}
}
