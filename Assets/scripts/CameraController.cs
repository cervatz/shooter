﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

//		transform.Translate(Vector3.up * Time.deltaTime);

		transform.Rotate(Vector3.right * Time.deltaTime);
	}
}
