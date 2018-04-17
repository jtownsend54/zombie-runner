using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {
	public AudioClip callHelo;

	private bool heloCalled = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("CallHelo") != 0f && !heloCalled) {
			AudioSource.PlayClipAtPoint (callHelo, transform.position);
			heloCalled = true;
		}
	}
}
