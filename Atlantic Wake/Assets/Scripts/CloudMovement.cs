﻿using UnityEngine;
using System.Collections;

public class CloudMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    transform.position += 0.01f*Vector3.left;
	}
}
