using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToQTEScene : MonoBehaviour {

	public GameObject Joueur;
	private float JoueurPrefX;
	private float JoueurPrefY;
	public GameObject Cafe1;
	public GameObject Cafe2;
	public GameObject Cafe3;
	public GameObject Cafe4;


	[SerializeField]
	private static GameObject Enemy1;

	[SerializeField]
	private string EnemyCourant;


	void  Awake(){
		JoueurPrefX = PlayerPrefs.GetFloat ("Axe X");
		JoueurPrefY = PlayerPrefs.GetFloat ("Axe Y");

		}


	void PositionJoueur(){
		PlayerPrefs.SetFloat ("Axe X", Joueur.transform.position.x +1.5f);
		PlayerPrefs.SetFloat ("Axe Y", Joueur.transform.position.y +1.5f);
		PlayerPrefs.SetInt (EnemyCourant, 0);
		//Debug.Log (EnemyCourant);
		//Debug.Log (EnemyCourant[8]);

		if ("C".Equals(EnemyCourant [8].ToString())) {
			PlayerPrefs.SetInt ("EnemyEnCours", 1);
			//Debug.Log(PlayerPrefs.GetInt("EnemyEnCours"));
			//Debug.Log ("Coucou");
		}
		if ("R".Equals(EnemyCourant [8].ToString())) {
			PlayerPrefs.SetInt ("EnemyEnCours", 2);
			Debug.Log ("Coucou");
		}
		if ("I".Equals(EnemyCourant [8].ToString())) {
			PlayerPrefs.SetInt ("EnemyEnCours", 3);
		}
		if ("T".Equals(EnemyCourant [8].ToString())) {
			PlayerPrefs.SetInt ("EnemyEnCours", 4);
		}

	}



	void OnTriggerEnter2D(Collider2D Enemy)
	{
		if (Enemy.CompareTag("Enemy"))
		{
			EnemyCourant = Enemy.gameObject.name;
			PositionJoueur ();

			SceneManager.LoadScene (1);
		}
	}
}
