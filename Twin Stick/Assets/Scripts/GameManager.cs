using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {

	private bool recording = false;
	private ReplaySystem[] recordedOjects;


	// Use this for initialization
	void Start () {

		recordedOjects = FindObjectsOfType(typeof(ReplaySystem)) as ReplaySystem[];
		//Debug.Log (recordedOjects.Length);

	}
	
	// Update is called once per frame
	void Update () {

		if (CrossPlatformInputManager.GetButton("Fire1")) {
			//Playback
			recording = false;

		} else {
			//Recording
			recording = true;
		}

		if (recording == true ) {
			foreach (ReplaySystem recObject in recordedOjects) {
				recObject.Record ();
			}
		}

		if (recording == false) {
			foreach (ReplaySystem recObject in recordedOjects) {
				recObject.PlayBack ();
			}
		}
		
	}
}
