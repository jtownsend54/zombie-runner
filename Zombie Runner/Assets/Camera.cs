using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
	Vector3 rotation;

	// Use this for initialization
	void Start () {
		rotation = new Vector3 (0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		rotation.y += 0.1f;
		transform.rotation = Quaternion.Euler(rotation);
	}
}
