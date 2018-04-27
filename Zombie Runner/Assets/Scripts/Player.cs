using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Player : FirstPersonController {
	public GameObject spawnPointContainer;
	public Helicopter helicopter;
	public bool doSpawn;

	private SpawnPoint[] spawnPoints;

	// Use this for initialization
	public override void Start () {
		base.Start();
		Debug.Log("Player Start");
	}
	
	// Update is called once per frame
	public override void Update () {
		base.Update();

		if (doSpawn) {
			ReSpawn();
		}

		doSpawn = false;
	}

	void ReSpawn() {
		spawnPoints = spawnPointContainer.GetComponentsInChildren<SpawnPoint> ();

		int randomIdx = Random.Range(0, spawnPoints.Length);

		GetComponent<Transform>().position = spawnPoints[randomIdx].GetComponent<Transform>().position;
	}

	void OnFindClearArea() {
		helicopter.doCallHelo ();
	}
}
