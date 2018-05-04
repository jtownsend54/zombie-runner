using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSystem : MonoBehaviour {
	public AudioClip requestHelo;
	public AudioClip helicopterInbound;

	private AudioSource radio;

	// Use this for initialization
	void Start () {
		radio = GetComponent<AudioSource> ();
	}
	
	void OnCallHelo() {
		radio.clip = requestHelo;
		radio.Play ();

		Invoke ("PlayHeloResponse", requestHelo.length + 2);

	}

	void PlayHeloResponse() {
		radio.clip = helicopterInbound;
		radio.Play ();
		BroadcastMessage ("OnDispatchHeloResponse");
	}

	void OnClearLandingFound() {
		BroadcastMessage ("OnDispatchClearLanding");
	}
}
