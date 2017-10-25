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

        //CollegueImprimante
        for ( int i = 0; i < 28; i++ ) {
            PlayerPrefs.SetInt( "collegueRelou (" + i + ")", 1 );
        }
        //CollegueImprimante
        for ( int i = 0; i < 10; i++ ) {
            PlayerPrefs.SetInt( "CollegueCafe (" + i + ")", 1 );
        }
        //CollegueImprimante
        for ( int i = 0; i < 29; i++ ) {
            PlayerPrefs.SetInt( "CollegueImprimante (" + i + ")", 1 );
        }
        //CollegueImprimante
        for ( int i = 0; i < 14; i++ ) {
            PlayerPrefs.SetInt( "CollegueToilettes" + i, 1 );
        }
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("StartKey") || Input.GetButtonDown( "Submit" ) ) {
			SceneManager.LoadScene (0);
	}
}
}