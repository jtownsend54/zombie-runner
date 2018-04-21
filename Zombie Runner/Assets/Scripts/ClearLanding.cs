using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearLanding : MonoBehaviour {
	
	private AudioSource foundLanding;
	private float checkTime;
	private bool foundLandingPlayed = false;

	// Use this for initialization
	void Start () {
		foundLanding = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		if (Time.time - checkTime >= 1 && !foundLandingPlayed) {
			foundLanding.Play ();
			foundLandingPlayed = true;
			Invoke ("triggerClearArea", 10);
		}
	}

	void triggerClearArea() {
		SendMessageUpwards ("OnFindClearArea");
	}

	void OnTriggerStay(Collider tree) {
		checkTime = Time.time;
	}
}
