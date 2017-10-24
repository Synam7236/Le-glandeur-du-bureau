using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToQTEScene : MonoBehaviour {

	public GameObject Joueur;
	private float JoueurPrefX;
	private float JoueurPrefY;


	[SerializeField]
	private static GameObject Enemy1;
    

	void  Awake(){
		JoueurPrefX = PlayerPrefs.GetFloat ("Axe X");
		JoueurPrefY = PlayerPrefs.GetFloat ("Axe Y");

		}


	void PositionJoueur( string EnemyCourant ) {
		PlayerPrefs.SetFloat ("Axe X", Joueur.transform.position.x +1.5f);
		PlayerPrefs.SetFloat ("Axe Y", Joueur.transform.position.y +1.5f);
		PlayerPrefs.SetInt (EnemyCourant, 0);

		if ("C".Equals(EnemyCourant [8].ToString())) {
			PlayerPrefs.SetInt ("EnemyEnCours", 1);
		}
		if ("R".Equals(EnemyCourant [8].ToString())) {
			PlayerPrefs.SetInt ("EnemyEnCours", 2);
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
			PositionJoueur ( Enemy.gameObject.name );
			SceneManager.LoadScene (1);
		}
	}
}
