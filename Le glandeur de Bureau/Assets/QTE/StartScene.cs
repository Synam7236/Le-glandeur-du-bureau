using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScene : MonoBehaviour {


    [SerializeField]
	private GameObject player;

    public Camera _camera;

    public GameObject[] CollegueRelou;
    public GameObject[] CollegueCafe;
    public GameObject[] CollegueImprimante;
    public GameObject[] CollegueToilettes;


    // Use this for initialization
    void Start () {
        //Debug.Log( CollegueRelou.Length );
        //Debug.Log( CollegueCafe.Length );
        //Debug.Log( CollegueImprimante.Length );
        //Debug.Log( CollegueToilettes.Length );

        //CollegueRelou
        for ( int i = 0; i < CollegueRelou.Length; i++ ) {
            if ( PlayerPrefs.GetInt( "collegueRelou (" + i + ")" ) == 0 ) {
                Debug.Log( CollegueRelou[i].name );
                Destroy( CollegueRelou[i] );
            }
        }
        //CollegueCafé
        for ( int i = 0; i < CollegueCafe.Length; i++ ) {
            if ( PlayerPrefs.GetInt( "CollegueCafe (" + i + ")" ) == 0 ) {
                Debug.Log( CollegueCafe[i].name );
                Destroy( CollegueCafe[i] );
            }
        }
        //CollegueImprimante
        for ( int i = 0; i < CollegueImprimante.Length; i++ ) {
            if ( PlayerPrefs.GetInt( "CollegueImprimante (" + i + ")" ) == 0 ) {
                Debug.Log( CollegueImprimante[i].name );
                Destroy( CollegueImprimante[i] );
            }
        }
        //CollegueToilettes
        for ( int i = 0; i < CollegueToilettes.Length; i++ ) {
            if ( PlayerPrefs.GetInt( "CollegueToilettes" + i ) == 0 ) {
                Debug.Log( CollegueToilettes[i].name );
                Destroy( CollegueToilettes[i] );
            }
        }

        //Garder la pos du joueur
        float posX = PlayerPrefs.GetFloat ("Axe X", -7.57f); // retourne la valeur contenu dans les playersprefs ou -7.57 par défaut
		float posY = PlayerPrefs.GetFloat ("Axe Y", -1.06f); // retourne la valeur contenu dans les playersprefs ou -1.06 par défaut
        player.transform.position = new Vector2( posX, posY );
        _camera.transform.position = new Vector2( posX, posY );


        //Placer la deadzone sur la pos de la camera
        _camera.GetComponent<DeadzoneCamera>().smoothPos.x = _camera.transform.position.x;
        _camera.GetComponent<DeadzoneCamera>().smoothPos.y = _camera.transform.position.y;


    }

}
