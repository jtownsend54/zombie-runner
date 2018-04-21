using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {
	public AudioClip callHelo;
	public AudioClip heloResponse;
	public AudioClip rotors;

	private bool heloCalled = false;
	private AudioSource audioSource;
	private Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody> ();
		audioSource = GetComponent<AudioSource> ();
		audioSource.clip = heloResponse;
	}
	
	// Update is called once per frame
//	void Update () {
//		
//	}

	public void doCallHelo() {
//		if (Input.GetAxis ("CallHelo") != 0f && !heloCalled) {
			audioSource.Play ();

			// Start the rotor sound five seconds after the helicopter response
			Invoke ("startHelo", 5);

			heloCalled = true;
//		}
	}

	void startHelo() {
		audioSource.clip = rotors;
		audioSource.loop = true;
		audioSource.spatialBlend = 1f;
		audioSource.Play ();
		rigidBody.velocity = new Vector3 (0, 0, 50);
	}
}
