using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

	float y_Position;
	float z_position;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log ("Horizontal: " + CrossPlatformInputManager.GetAxis ("Horizontal"));
		//Debug.Log ("Vertical: " + CrossPlatformInputManager.GetAxis ("Vertical"));

		y_Position = this.transform.position.y;
		z_position = this.transform.position.z;

		this.transform.position = new Vector3 (0, y_Position, z_position);

	}
}
