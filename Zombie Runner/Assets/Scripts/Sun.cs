using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour {
	// Minutes per second
	public float timeScale;

	private Vector3 rotation;

	// Use this for initialization
	void Start () {
		rotation = new Vector3 (timeScale / 3600, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (rotation);
	}
}
