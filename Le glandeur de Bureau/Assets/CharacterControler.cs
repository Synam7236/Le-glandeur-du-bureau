using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControler : MonoBehaviour {

	public float speed = 0.18f;
	public float jumph = 4.01f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 dp = new Vector3();

		if (Input.GetKey (KeyCode.Q)) {
			dp.x -= speed;
		}

		if (Input.GetKey (KeyCode.D)) {
			dp.x += speed; 
		}

		transform.position += dp;
		
	}
}
