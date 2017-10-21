using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetFloat ("Axe X", -7.57f);
		PlayerPrefs.SetFloat ("Axe Y", -1.06f);
		PlayerPrefs.SetInt("Enemy1", 1);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("StartKey")){
			SceneManager.LoadScene (0);
	}
}
}