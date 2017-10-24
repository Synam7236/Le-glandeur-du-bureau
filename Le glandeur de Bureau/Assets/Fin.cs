using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fin : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D Enemy)
	{
		if (Enemy.CompareTag("Fin"))
		{

			SceneManager.LoadScene (3);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
