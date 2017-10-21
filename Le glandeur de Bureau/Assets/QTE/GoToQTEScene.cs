using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToQTEScene : MonoBehaviour {

	public GameObject Joueur;
	private float JoueurPrefX;
	private float JoueurPrefY;

	void  Awake(){
		JoueurPrefX = PlayerPrefs.GetFloat ("Axe X");
		JoueurPrefY = PlayerPrefs.GetFloat ("Axe Y");

		}


	void PositionJoueur(){
		PlayerPrefs.SetFloat ("Axe X", Joueur.transform.position.x);
		PlayerPrefs.SetFloat ("Axe Y", Joueur.transform.position.y);
		PlayerPrefs.SetInt ("Enemy1", 0);
	}


	//void Awake() {
		//DontDestroyOnLoad(Joueur.gameObject);
	//}

	void OnTriggerEnter2D(Collider2D Enemy)
	{
		if (Enemy.CompareTag("Enemy"))
		{
			PositionJoueur ();

			SceneManager.LoadScene (1);
		}
	}
}
