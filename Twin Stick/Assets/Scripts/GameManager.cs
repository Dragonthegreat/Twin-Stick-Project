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
			foreach (ReplaySystem recObject in recordedOjects) {
				recObject.PlayBack ();
				Debug.Log (recObject.gameObject);
			}
		} else {
			//Recording
			foreach (ReplaySystem recObject in recordedOjects) {
				recObject.Record ();
			}
		}
		
	}
}
