using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Player : MonoBehaviour {
	public GameObject spawnPointContainer;
//	public Helicopter helicopter;
	public bool doSpawn;

	private SpawnPoint[] spawnPoints;
	// private AudioSource innerVoice;

	// Use this for initialization
//	public override void Start () {
//		base.Start();
//
//		foreach (AudioSource source in GetComponents<AudioSource>()) {
//			if (source.priority == 1) {
//				innerVoice = source;
//			} else {
//				base.m_AudioSource = source;
//			}
//		}
//
//		innerVoice.Play ();
//	}
	
	// Update is called once per frame
//	public override void Update () {
//		if (doSpawn) {
//			ReSpawn();
//		}
//
//		doSpawn = false;
//	}
//
	void ReSpawn() {
		spawnPoints = spawnPointContainer.GetComponentsInChildren<SpawnPoint> ();

		int randomIdx = Random.Range(0, spawnPoints.Length);

		GetComponent<Transform>().position = spawnPoints[randomIdx].GetComponent<Transform>().position;
	}

	void OnCallHelo() {
		Debug.Log ("Laydown a flare");
	}

//	void OnFindClearArea() {
//		helicopter.doCallHelo ();
//	}
}
