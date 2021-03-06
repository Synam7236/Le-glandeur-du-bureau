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
	public GameObject BOUTONA1;
	public GameObject BOUTONBAS3;
	public GameObject BOUTONDROITE1;
	public GameObject BOUTONGAUCHE3;
	public GameObject BOUTONHAUT1;
	public float SecondesQTE;
	public float ToleranceAngle;
	private int BoutonDisplayGEN;
	private int BoutonCouleurGEN;
	private Vector2[] tableauDisplay;
	//private int[] tableauCouleur;
	public GameObject RIGHT;
	public GameObject WRONG;
	public GameObject CollegueRelouQTE;
	public GameObject CollegueCafeQTE;
	public GameObject ImprimanteQTE;
	public GameObject ToilettesQTE;
	private int TypeQTE;



	//private int Cafe;

	// Choisis une touche et l'affiche sur l'écran
	void Start(){
		tableauDisplay = new Vector2[] {
			new Vector2 (0f, 0f),
			new Vector2 (0f, -4f),
			new Vector2 (0f, 4f),
			new Vector2 (-5.9f, 0f),
			new Vector2 (7f, 0f)
		};


		//new Vector2 (3.613f, 1.97f),
		//new Vector2 (3.613f, -2f),
		//new Vector2 (3.613f, 6f),
		//new Vector2 (-3f, 1.983f),
		//new Vector2 (10f, 1.983f)

	}

	void Update(){

		if (NbredeQTEpass <= NbredeQTE) {
			if (WaitingForKey == 0) {
				QTEGen = Random.Range (1, 6);
				CountingDown = 1;
				StartCoroutine (CountDown ());
				BOUTONA1.SetActive (false);
				BOUTONBAS3.SetActive (false);
				BOUTONDROITE1.SetActive (false);
				BOUTONGAUCHE3.SetActive (false);
				BOUTONHAUT1.SetActive (false);
				RIGHT.SetActive (false);
				WRONG.SetActive (false);
				CollegueRelouQTE.SetActive (false);
				CollegueCafeQTE.SetActive (false);
				ToilettesQTE.SetActive (false);
				ImprimanteQTE.SetActive (false);

				TypeQTE = PlayerPrefs.GetInt ("EnemyEnCours");
                //Debug.Log(TypeQTE);

                if ( TypeQTE == 2 ) {
                    CollegueRelouQTE.SetActive( true );
                }
                if (TypeQTE == 1) {
					CollegueCafeQTE.SetActive (true);
				}
				if (TypeQTE == 3) {
					ImprimanteQTE.SetActive (true);
				}
				if (TypeQTE == 4) {
					ToilettesQTE.SetActive (true);
				}
					


				BoutonDisplayGEN = Random.Range (0, 5);
				BoutonCouleurGEN =Random.Range(1,4);



				if (QTEGen == 1) {
					WaitingForKey = 1;
					//DisplayBox.GetComponent<Text> ().text = "A";
					BOUTONA1.transform.position= new Vector2(tableauDisplay[BoutonDisplayGEN].x,tableauDisplay[BoutonDisplayGEN].y);
					BOUTONA1.SetActive (true);

				}
				if (QTEGen == 2) {
					WaitingForKey = 1;
					//DisplayBox.GetComponent<Text> ().text = "BAS";
					BOUTONBAS3.SetActive (true);
					BOUTONBAS3.transform.position= new Vector2(tableauDisplay[BoutonDisplayGEN].x,tableauDisplay[BoutonDisplayGEN].y);

				}
				if (QTEGen == 3) {
					WaitingForKey = 1;
					//DisplayBox.GetComponent<Text> ().text = "DROITE";
					BOUTONDROITE1.SetActive (true);
					BOUTONDROITE1.transform.position= new Vector2(tableauDisplay[BoutonDisplayGEN].x,tableauDisplay[BoutonDisplayGEN].y);

				}
				if (QTEGen == 4) {
					WaitingForKey = 1;
					//DisplayBox.GetComponent<Text> ().text = "GAUCHE";
					BOUTONGAUCHE3.SetActive (true);
					BOUTONGAUCHE3.transform.position= new Vector2(tableauDisplay[BoutonDisplayGEN].x,tableauDisplay[BoutonDisplayGEN].y);

				}
				if (QTEGen == 5) {
					WaitingForKey = 1;
					//DisplayBox.GetComponent<Text> ().text = "HAUT";
					BOUTONHAUT1.SetActive (true);
					BOUTONHAUT1.transform.position= new Vector2(tableauDisplay[BoutonDisplayGEN].x,tableauDisplay[BoutonDisplayGEN].y);

				}
			}


			// Vérifie que la touche choisie soit la bonne
		
			//Bouton A
			if (QTEGen == 1) {
				if (Input.anyKeyDown || (Input.GetAxis("Horizontal")!= 0)|| (Input.GetAxis("Vertical"))!=0) {
					if (Input.GetButtonDown ("AKey")) {
						CorrectKey = 1;
						StartCoroutine (KeyPressing ());
						NbredeQTEpass += 1;
					} else {
						CorrectKey = 2;
					}
				}
			}

			//BAS
			if (QTEGen == 2) {
				if (Input.anyKeyDown || (Input.GetAxis("Horizontal")!= 0)|| (Input.GetAxis("Vertical"))!=0) {
					if ((Input.GetAxis("Vertical") < 0) && (-ToleranceAngle<Input.GetAxis("Horizontal")) && (Input.GetAxis("Horizontal") <ToleranceAngle)){
						CorrectKey = 1;
						StartCoroutine (KeyPressing ());
						NbredeQTEpass += 1;
					} else {
						CorrectKey = 2;
					}
				}
			}

			//DROITE
			if (QTEGen == 3) {
				if (Input.anyKeyDown || (Input.GetAxis("Horizontal")!= 0)|| (Input.GetAxis("Vertical"))!=0) {
					if ((Input.GetAxis ("Horizontal")>0) && (-ToleranceAngle<Input.GetAxis("Vertical")) && (Input.GetAxis("Vertical") <ToleranceAngle)) {
						CorrectKey = 1;
						StartCoroutine (KeyPressing ());
						NbredeQTEpass += 1;
					} else {
						CorrectKey = 2;
					}
				}
			}



			//GAUCHE
			if (QTEGen == 4) {
				if (Input.anyKeyDown || (Input.GetAxis("Horizontal")!= 0)|| (Input.GetAxis("Vertical"))!=0) {
					if ((Input.GetAxis("Horizontal")<0)&& (-ToleranceAngle<Input.GetAxis("Vertical")) && (Input.GetAxis("Vertical") <ToleranceAngle)) {
						CorrectKey = 1;
						StartCoroutine (KeyPressing ());
						NbredeQTEpass += 1;
					} else {
						CorrectKey = 2;
					}
				}
			}

			//HAUT
			if (QTEGen == 5) {
				if (Input.anyKeyDown || (Input.GetAxis("Horizontal")!= 0)|| (Input.GetAxis("Vertical"))!=0) {
					if ((Input.GetAxis("Vertical") > 0) && (-ToleranceAngle<Input.GetAxis("Horizontal")) && (Input.GetAxis("Horizontal") <ToleranceAngle)) {
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
			SceneManager.LoadScene (1);
		}
	}



	// Affiche le résultat Pass ou Fail

	IEnumerator KeyPressing(){
		QTEGen = 10;
		if (CorrectKey == 1){
			CountingDown = 2;
			RIGHT.SetActive (true);
			//PassBox.GetComponent<Text> ().text = " Pass ";
			yield return new WaitForSeconds(SecondesQTE);
			CorrectKey = 0;
			//PassBox.GetComponent<Text> ().text = "";
			DisplayBox.GetComponent<Text>().text = "";
			yield return new WaitForSeconds(SecondesQTE);
			WaitingForKey = 0;
			CountingDown = 1;



		}
		if (CorrectKey == 2){
			CountingDown = 2;
			WRONG.SetActive (true);
			//PassBox.GetComponent<Text> ().text = " FAIL ";
			yield return new WaitForSeconds(SecondesQTE);
			CorrectKey = 0;
			//PassBox.GetComponent<Text> ().text = "";
			//DisplayBox.GetComponent<Text>().text = "";
			yield return new WaitForSeconds(SecondesQTE);
			WaitingForKey = 0;
			CountingDown = 1;

		}

	}




	IEnumerator CountDown() {
		yield return new WaitForSeconds (SecondesQTE);
		if (CountingDown == 1) {
			QTEGen = 1;
			CountingDown = 2;
			WRONG.SetActive (true);
			//PassBox.GetComponent<Text> ().text = "FAIL";
			yield return new WaitForSeconds(SecondesQTE);
			CorrectKey = 0;
			//PassBox.GetComponent<Text> ().text = "";
			//DisplayBox.GetComponent<Text>().text = "";
			yield return new WaitForSeconds(SecondesQTE);
			WaitingForKey = 0;
			CountingDown = 1;

		}

	}
		






}