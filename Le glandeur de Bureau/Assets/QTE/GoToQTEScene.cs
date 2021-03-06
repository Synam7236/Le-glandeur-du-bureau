﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToQTEScene : MonoBehaviour {

	public GameObject Joueur;
    public Camera _camera;
	private float JoueurPrefX;
	private float JoueurPrefY;


	[SerializeField]
	private static GameObject Enemy1;
    

	void  Awake(){
		//JoueurPrefX = PlayerPrefs.GetFloat ("Axe X");
		//JoueurPrefY = PlayerPrefs.GetFloat ("Axe Y");

	}


	void PositionJoueur( string EnemyCourant ) {
		PlayerPrefs.SetFloat ("Axe X", Joueur.transform.position.x /*+1.5f*/);
		PlayerPrefs.SetFloat ("Axe Y", Joueur.transform.position.y /*+1.5f*/);
        PlayerPrefs.SetFloat( "posCamX", _camera.transform.position.x);
        PlayerPrefs.SetFloat( "posCamY", _camera.transform.position.y);
        PlayerPrefs.SetInt (EnemyCourant, 0);

        if ( "h".Equals( EnemyCourant[0].ToString() ) ) {
            PlayerPrefs.SetInt( "EnemyEnCours", 4 );
        } else if ("C".Equals(EnemyCourant [8].ToString())) {
			PlayerPrefs.SetInt ("EnemyEnCours", 1);
        } else if ( "R".Equals(EnemyCourant [8].ToString())) {
			PlayerPrefs.SetInt ("EnemyEnCours", 2);
		} else if ("I".Equals(EnemyCourant [8].ToString())) {
			PlayerPrefs.SetInt ("EnemyEnCours", 3);
		}

	}

    void OnCollisionEnter2D( Collision2D coll ) {
        if ( coll.gameObject.tag == "Enemy" ) {

            Debug.Log( coll.gameObject.name );
            PlayerPrefs.SetInt( coll.gameObject.name, 0 );
            PositionJoueur( coll.gameObject.name );
            SceneManager.LoadScene( 2 );
        }

    }

    void OnTriggerEnter2D(Collider2D Enemy) {
        if (Enemy.CompareTag("Enemy") || Enemy.CompareTag( "Toilette" ) )
		{
            Debug.Log( Enemy.gameObject.name );
            Enemy.enabled = false;
            PlayerPrefs.SetInt( Enemy.gameObject.name, 0 );
            PositionJoueur ( Enemy.gameObject.name );
			SceneManager.LoadScene (2);
		}
	}
}
