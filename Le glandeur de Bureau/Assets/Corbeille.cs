﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corbeille : MonoBehaviour {
	public Animator anim;

	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D( Collider2D other) {
		Debug.Log("Plop");
		anim.enabled = true;
	}
}
