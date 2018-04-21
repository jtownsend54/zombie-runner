using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour {

	private Camera camera;
	private float playerFOV;

	// Use this for initialization
	void Start () {
		camera = GetComponent<Camera> ();
		playerFOV = camera.fieldOfView;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("Zoom") != 0f) {
			camera.fieldOfView = playerFOV - (playerFOV * .5f);
		} else {
			camera.fieldOfView = playerFOV;
		}
	}
}
