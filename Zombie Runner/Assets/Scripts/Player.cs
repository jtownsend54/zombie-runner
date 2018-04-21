using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public GameObject spawnPointContainer;
	public Helicopter helicopter;
	public bool doSpawn;

	private SpawnPoint[] spawnPoints;

	// Use this for initialization
	void Start () {
		//ReSpawn ();
	}
	
	// Update is called once per frame
	void Update () {
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
		Debug.Log ("In player script");
		helicopter.doCallHelo ();
	}
}
