﻿using UnityEngine;
using System.Collections;

public class Door1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if(other.CompareTag("door")){
			Application.LoadLevel(1); 
		}
	}
}
