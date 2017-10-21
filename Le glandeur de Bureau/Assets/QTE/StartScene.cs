using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScene : MonoBehaviour {

	[SerializeField]
	private GameObject player;
	[SerializeField]
	private GameObject Enemy1;


	// Use this for initialization
	void Start () {
		int Enemy1Bool = PlayerPrefs.GetInt("Enemy1");
		if (Enemy1Bool == 0) {
			Debug.Log (Enemy1);
			Debug.Log ("je suis passé par ici");
			Destroy (Enemy1);
		}

		float posX = PlayerPrefs.GetFloat ("Axe X", -7.57f);
		float posY = PlayerPrefs.GetFloat ("Axe Y", -1.06f);

		player.transform.position = new Vector2 (posX, posY);


	}

}
