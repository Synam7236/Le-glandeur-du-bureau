using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class QTEFonctionsNEWScene: MonoBehaviour {

	public GameObject DisplayBox;
	public GameObject PassBox;
	public int QTEGen;
	public int WaitingForKey;
	public int CorrectKey;
	public int CountingDown;
	public int NbredeQTE;
	public int NbredeQTEpass;
	public GameObject Réussi;

	// Choisis une touche et l'affiche sur l'écran
	void Start(){
		
	}

	void Update(){

		if (NbredeQTEpass <= NbredeQTE) {
			if (WaitingForKey == 0) {
				QTEGen = Random.Range (1, 5);
				CountingDown = 1;
				StartCoroutine (CountDown ());


				if (QTEGen == 1) {
					WaitingForKey = 1;
					DisplayBox.GetComponent<Text> ().text = "A";
				}
				if (QTEGen == 2) {
					WaitingForKey = 1;
					DisplayBox.GetComponent<Text> ().text = "B";
				}
				if (QTEGen == 3) {
					WaitingForKey = 1;
					DisplayBox.GetComponent<Text> ().text = "X";
				}
				if (QTEGen == 4) {
					WaitingForKey = 1;
					DisplayBox.GetComponent<Text> ().text = "Y";
				}
			}


			// Vérifie que la touche choisie soit la bonne
		
			if (QTEGen == 1) {
				if (Input.anyKeyDown) {
					if (Input.GetButtonDown ("AKey")) {
						CorrectKey = 1;
						StartCoroutine (KeyPressing ());
						NbredeQTEpass += 1;
					} else {
						CorrectKey = 2;
					}
				}
			}

			if (QTEGen == 2) {
				if (Input.anyKeyDown) {
					if (Input.GetButtonDown ("BKey")) {
						CorrectKey = 1;
						StartCoroutine (KeyPressing ());
						NbredeQTEpass += 1;
					} else {
						CorrectKey = 2;
					}
				}
			}


			if (QTEGen == 3) {
				if (Input.anyKeyDown) {
					if (Input.GetButtonDown ("XKey")) {
						CorrectKey = 1;
						StartCoroutine (KeyPressing ());
						NbredeQTEpass += 1;
					} else {
						CorrectKey = 2;
					}
				}
			}




			if (QTEGen == 4) {
				if (Input.anyKeyDown) {
					if (Input.GetButtonDown ("YKey")) {
						CorrectKey = 1;
						StartCoroutine (KeyPressing ());
						NbredeQTEpass += 1;
					} else {
						CorrectKey = 2;
					}
				}
			}

		} else {
			Réussi.GetComponent<Text> ().text = "GG!";
			SceneManager.LoadScene (0);
		}
	}



	// Affiche le résultat Pass ou Fail

	IEnumerator KeyPressing(){
		QTEGen = 10;
		if (CorrectKey == 1){
			CountingDown = 2;
			PassBox.GetComponent<Text> ().text = " Pass ";
			yield return new WaitForSeconds(0.5f);
			CorrectKey = 0;
			PassBox.GetComponent<Text> ().text = "";
			DisplayBox.GetComponent<Text>().text = "";
			yield return new WaitForSeconds(0.5f);
			WaitingForKey = 0;
			CountingDown = 1;



		}
		if (CorrectKey == 2){
			CountingDown = 2;
			PassBox.GetComponent<Text> ().text = " FAIL ";
			yield return new WaitForSeconds(0.5f);
			CorrectKey = 0;
			PassBox.GetComponent<Text> ().text = "";
			DisplayBox.GetComponent<Text>().text = "";
			yield return new WaitForSeconds(0.5f);
			WaitingForKey = 0;
			CountingDown = 1;

		}

	}




	IEnumerator CountDown() {
		yield return new WaitForSeconds (0.5f);
		if (CountingDown == 1) {
			QTEGen = 1;
			CountingDown = 2;
			PassBox.GetComponent<Text> ().text = "FAIL";
			yield return new WaitForSeconds(0.5f);
			CorrectKey = 0;
			PassBox.GetComponent<Text> ().text = "";
			DisplayBox.GetComponent<Text>().text = "";
			yield return new WaitForSeconds(0.5f);
			WaitingForKey = 0;
			CountingDown = 1;

		}

	}
		


}