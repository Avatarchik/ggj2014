﻿using UnityEngine;
using System.Collections;

public class DestroyerOnLeave : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("OTHER!");
		if (other.gameObject.tag == "baby") {
			Destroy (other.gameObject);
		}
	}
}
