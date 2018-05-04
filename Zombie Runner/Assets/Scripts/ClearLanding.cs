using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearLanding : MonoBehaviour {
	private float checkTime;
	private bool foundLanding = false;
	private float callHeloDelay = 10;

	// Update is called once per frame
	void Update () {
		// Give the initial "where am I" sound some time to play before calling this.
		if (Time.timeSinceLevelLoad < callHeloDelay) {
			return;
		}

		if (Time.time - checkTime >= 1 && !foundLanding) {
			SendMessageUpwards ("OnClearLandingFound");
			foundLanding = true;
		}
	}

	void OnTriggerStay(Collider tree) {
		if (tree.tag == "Player") {
			return;
		}

		checkTime = Time.time;
	}
}
