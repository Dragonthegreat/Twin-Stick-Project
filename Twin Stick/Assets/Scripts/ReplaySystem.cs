using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaySystem : MonoBehaviour {

	private const int bufferFrames = 100;
	private MyKeyFrame[] keyFrame = new MyKeyFrame [bufferFrames];

	private Rigidbody rigidBody;

	// Use this for initialization
	void Start () {

		rigidBody = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {

		Record ();
	}

	void PlayBack () {
		rigidBody.isKinematic = true;
		int frame = Time.frameCount % bufferFrames;
		Debug.Log ("Reading to frame: " + frame);
		transform.position = keyFrame [frame].objectPosition;
		transform.rotation = keyFrame [frame].objectRotation;
	}


	void Record ()
	{
		rigidBody.isKinematic = false;
		int frame = Time.frameCount % bufferFrames;
		float time = Time.time;
		Debug.Log ("Writing to frame: " + frame);
		keyFrame [frame] = new MyKeyFrame (time, transform.position, transform.rotation);
	}
}
/// <summary>
/// A "strut" for storing time, position and rotation.
/// </summary>
public struct MyKeyFrame {
	public float time;
	public Vector3 objectPosition;
	public Quaternion objectRotation;

	public MyKeyFrame(float atime, Vector3 aobjectPosition, Quaternion aobjectRotation) {
		time = atime;
		objectPosition = aobjectPosition;
		objectRotation = aobjectRotation;
	}

}
