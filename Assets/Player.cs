using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

	[Tooltip("In meters/sec")][SerializeField] float xSpeed = 15f;
	[Tooltip("Max left/right position")][SerializeField] float xRange = 5.0f;
	[Tooltip("In meters/sec")][SerializeField] float ySpeed = 15f;
	[Tooltip("Max left/right position")][SerializeField] float yRange = 3.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		movePlayer();
		rotatePlayer();
	}

	void movePlayer() {
		// x axis
		float xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
		float xOffset = xThrow * xSpeed * Time.deltaTime;
		float rawNewXpos = transform.localPosition.x + xOffset;
		float clampedXPos = Mathf.Clamp(rawNewXpos, -xRange, xRange);
		transform.localPosition = new Vector3(clampedXPos, transform.localPosition.y, transform.localPosition.z);

		// y-axis
		float yThrow = CrossPlatformInputManager.GetAxis("Vertical");
		float yOffset = yThrow * ySpeed * Time.deltaTime;
		float rawNewYpos = transform.localPosition.y + yOffset;
		float clampedYPos = Mathf.Clamp(rawNewYpos, -yRange, yRange);
		transform.localPosition = new Vector3(transform.localPosition.x, clampedYPos,transform.localPosition.z);
	}

	void rotatePlayer(){

		
		transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
	}
}
