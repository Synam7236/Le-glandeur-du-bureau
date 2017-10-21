using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticScript : MonoBehaviour {
	public GameObject Joueur;
	private float JoueurPrefX;
	private float JoueurPrefY;

	// Use this for initialization
	void Start () {
		JoueurPrefX = PlayerPrefs.GetFloat ("Axe X");
		JoueurPrefY = PlayerPrefs.GetFloat ("Axe Y");
		Joueur.transform.position = new  Vector2 (JoueurPrefX, JoueurPrefY);
		//Joueur.transform.position = transform.position.Set (JoueurPrefX, JoueurPrefY);
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	//JoueurPrefX = PlayerPrefs.GetFloat ("Axe X");
	//JoueurPrefY = PlayerPrefs.GetFloat ("Axe Y");

	//Joueur.transform.position = new  Vector2 (JoueurPrefX, JoueurPrefY);
	//Joueur.transform.position = transform.position.Set (JoueurPrefX, JoueurPrefY);

	//Vector2 temp = transform.position;
	//temp.x = JoueurPrefX;
	//transform.position.x = temp.x;
	//temp.y = JoueurPrefY;
	//transform.position.y = temp.y;

	//Joueur.transform.position.x = JoueurPrefX;
	//Joueur.transform.position.y = JoueurPrefY;

}
