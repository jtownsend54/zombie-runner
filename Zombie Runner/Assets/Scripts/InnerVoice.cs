using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerVoice : MonoBehaviour {
	public AudioClip whatHappened;
	public AudioClip clearLanding;

	private AudioSource innerVoice;

	// Use this for initialization
	void Start () {
		innerVoice = GetComponent<AudioSource> ();
		innerVoice.clip = whatHappened;
		innerVoice.Play ();
	}
	
	void OnDispatchClearLanding() {
		innerVoice.clip = clearLanding;
		innerVoice.Play ();

		Invoke ("triggerClearArea", clearLanding.length + 2);
	}

	void triggerClearArea() {
		SendMessageUpwards ("OnCallHelo");
	}
}