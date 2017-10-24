using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScene : MonoBehaviour {


    [SerializeField]
	private GameObject player;

    public GameObject[] CollegueRelou;
    public GameObject[] CollegueCafe;
    public GameObject[] CollegueImprimante;
    public GameObject[] CollegueToilettes;


    // Use this for initialization
    void Start () {
        Debug.Log( CollegueRelou.Length );
        Debug.Log( CollegueCafe.Length );
        Debug.Log( CollegueImprimante.Length );
        Debug.Log( CollegueToilettes.Length );

        //CollegueRelou
        for ( int i = 0; i < CollegueRelou.Length; i++ ) {
            if ( PlayerPrefs.GetInt( "CollegueRelou" + i ) == 0 ) {
                Destroy( CollegueRelou[i] );
            }
        }
        //CollegueCafé
        for ( int i = 0; i < CollegueCafe.Length; i++ ) {
            if ( PlayerPrefs.GetInt( "CollegueRelou" + i ) == 0 ) {
                Destroy( CollegueCafe[i] );
            }
        }
        //CollegueImprimante
        for ( int i = 0; i < CollegueImprimante.Length; i++ ) {
            if ( PlayerPrefs.GetInt( "CollegueRelou" + i ) == 0 ) {
                Destroy( CollegueImprimante[i] );
            }
        }
        //CollegueToilettes
        for ( int i = 0; i < CollegueToilettes.Length; i++ ) {
            if ( PlayerPrefs.GetInt( "CollegueRelou" + i ) == 0 ) {
                Destroy( CollegueToilettes[i] );
            }
        }

        //Garder la pos du joueur

        float posX = PlayerPrefs.GetFloat ("Axe X", -7.57f); // retourne la valeur contenu dans les playersprefs ou -7.57 par défaut
		float posY = PlayerPrefs.GetFloat ("Axe Y", -1.06f); // retourne la valeur contenu dans les playersprefs ou -1.06 par défaut

        player.transform.position = new Vector2 (posX, posY);


	}

}
