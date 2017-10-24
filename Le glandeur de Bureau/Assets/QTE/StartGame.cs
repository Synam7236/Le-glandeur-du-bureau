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


		PlayerPrefs.SetInt("CollegueRelou1", 1);
		PlayerPrefs.SetInt("CollegueRelou2", 1);
		PlayerPrefs.SetInt("CollegueRelou3", 1);
		PlayerPrefs.SetInt("CollegueRelou4", 1);
		PlayerPrefs.SetInt("CollegueRelou5", 1);
		PlayerPrefs.SetInt("CollegueRelou6", 1);
		PlayerPrefs.SetInt("CollegueRelou7", 1);
		PlayerPrefs.SetInt("CollegueRelou8", 1);
		PlayerPrefs.SetInt("CollegueRelou9", 1);
		PlayerPrefs.SetInt("CollegueRelou10", 1);
		PlayerPrefs.SetInt("CollegueRelou11", 1);
		PlayerPrefs.SetInt("CollegueRelou12", 1);
		PlayerPrefs.SetInt("CollegueRelou13", 1);
		PlayerPrefs.SetInt("CollegueRelou14", 1);
		PlayerPrefs.SetInt("CollegueRelou15", 1);
		PlayerPrefs.SetInt("CollegueRelou16", 1);
		PlayerPrefs.SetInt("CollegueRelou17", 1);
		PlayerPrefs.SetInt("CollegueRelou18", 1);
		PlayerPrefs.SetInt("CollegueRelou19", 1);
		PlayerPrefs.SetInt("CollegueRelou20", 1);
		PlayerPrefs.SetInt("CollegueRelou21", 1);
		PlayerPrefs.SetInt("CollegueRelou22", 1);
		PlayerPrefs.SetInt("CollegueRelou23", 1);
		PlayerPrefs.SetInt("CollegueRelou24", 1);
		PlayerPrefs.SetInt("CollegueRelou25", 1);
		PlayerPrefs.SetInt("CollegueRelou26", 1);
		PlayerPrefs.SetInt("CollegueRelou27", 1);
		PlayerPrefs.SetInt("CollegueRelou28", 1);


		PlayerPrefs.SetInt("CollegueCafe1", 1);
		PlayerPrefs.SetInt("CollegueCafe2", 1);
		PlayerPrefs.SetInt("CollegueCafe3", 1);
		PlayerPrefs.SetInt("CollegueCafe4", 1);
		PlayerPrefs.SetInt("CollegueCafe5", 1);
		PlayerPrefs.SetInt("CollegueCafe6", 1);
		PlayerPrefs.SetInt("CollegueCafe7", 1);
		PlayerPrefs.SetInt("CollegueCafe8", 1);
		PlayerPrefs.SetInt("CollegueCafe9", 1);
		PlayerPrefs.SetInt("CollegueCafe10", 1);

		PlayerPrefs.SetInt("CollegueToilettes1", 1);
		PlayerPrefs.SetInt("CollegueToilettes2", 1);
		PlayerPrefs.SetInt("CollegueToilettes3", 1);
		PlayerPrefs.SetInt("CollegueToilettes4", 1);
		PlayerPrefs.SetInt("CollegueToilettes5", 1);
		PlayerPrefs.SetInt("CollegueToilettes6", 1);
		PlayerPrefs.SetInt("CollegueToilettes7", 1);
		PlayerPrefs.SetInt("CollegueToilettes8", 1);
		PlayerPrefs.SetInt("CollegueToilettes9", 1);
		PlayerPrefs.SetInt("CollegueToilettes10", 1);
		PlayerPrefs.SetInt("CollegueToilettes11", 1);
		PlayerPrefs.SetInt("CollegueToilettes12", 1);
		PlayerPrefs.SetInt("CollegueToilettes13", 1);



	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("StartKey")){
			SceneManager.LoadScene (0);
	}
}
}