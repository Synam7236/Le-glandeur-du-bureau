using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScene : MonoBehaviour {

	[SerializeField]
	private GameObject player;
	[SerializeField]
	private GameObject CollegueRelou1;
	public  GameObject CollegueRelou2;
	public  GameObject CollegueRelou3;
	public  GameObject CollegueRelou4;
	public  GameObject CollegueRelou5;
	public  GameObject CollegueRelou6;
	public  GameObject CollegueRelou7;
	public  GameObject CollegueRelou8;
	public  GameObject CollegueRelou9;
	public  GameObject CollegueRelou10;
	public  GameObject CollegueRelou11;
	public  GameObject CollegueRelou12;
	public  GameObject CollegueRelou13;
	public  GameObject CollegueRelou14;
	public  GameObject CollegueRelou15;
	public  GameObject CollegueRelou16;
	public  GameObject CollegueRelou17;
	public  GameObject CollegueRelou18;
	public  GameObject CollegueRelou19;
	public  GameObject CollegueRelou20;
	public  GameObject CollegueRelou21;
	public  GameObject CollegueRelou22;
	public  GameObject CollegueRelou23;
	public  GameObject CollegueRelou24;
	public  GameObject CollegueRelou25;
	public  GameObject CollegueRelou26;
	public  GameObject CollegueRelou27;
	public  GameObject CollegueRelou28;


	public GameObject CollegueCafe1;
	public GameObject CollegueCafe2;
	public GameObject CollegueCafe3;
	public GameObject CollegueCafe4;
	public GameObject CollegueCafe5;
	public GameObject CollegueCafe6;
	public GameObject CollegueCafe7;
	public GameObject CollegueCafe8;
	public GameObject CollegueCafe9;
	public GameObject CollegueCafe10;

	/*public GameObject CollegueImprimante1;
	public GameObject CollegueImprimante2;
	public GameObject CollegueImprimante3;
	public GameObject CollegueImprimante4;
	public GameObject CollegueImprimante5;
	public GameObject CollegueImprimante6;
	public GameObject CollegueImprimante7;
	public GameObject CollegueImprimante8;
	public GameObject CollegueImprimante9;
	public GameObject CollegueImprimante10;
	public GameObject CollegueImprimante11;
	public GameObject CollegueImprimante12;
	public GameObject CollegueImprimante13;
	public GameObject CollegueImprimante14;
	public GameObject CollegueImprimante15;
	public GameObject CollegueImprimante16;
	public GameObject CollegueImprimante17;
	public GameObject CollegueImprimante18;
	public GameObject CollegueImprimante19;
	public GameObject CollegueImprimante20;
	public GameObject CollegueImprimante21;
	public GameObject CollegueImprimante22;
	public GameObject CollegueImprimante23;
	public GameObject CollegueImprimante24;
	public GameObject CollegueImprimante25;	
	public GameObject CollegueImprimante26;
	public GameObject CollegueImprimante27;
	public GameObject CollegueImprimante28;
*/
	public GameObject CollegueToilettes0;
	public GameObject CollegueToilettes1;
	public GameObject CollegueToilettes2;
	public GameObject CollegueToilettes3;
	public GameObject CollegueToilettes4;
	public GameObject CollegueToilettes5;
	public GameObject CollegueToilettes6;
	public GameObject CollegueToilettes7;
	public GameObject CollegueToilettes8;
	public GameObject CollegueToilettes9;
	public GameObject CollegueToilettes10;
	public GameObject CollegueToilettes11;
	public GameObject CollegueToilettes12;
	public GameObject CollegueToilettes13;


	// Use this for initialization
	void Start () {

		//CollegueRelou
		/*
		int RelouBool1 = PlayerPrefs.GetInt("CollegueRelou1");
		if (RelouBool1 == 0) {
			Destroy (CollegueRelou1);
		}
		int RelouBool2 = PlayerPrefs.GetInt("CollegueRelou2");
		if (RelouBool2 == 0) {
			Debug.Log ("Coucou");
			Destroy (CollegueRelou2);
		}
		int RelouBool3 = PlayerPrefs.GetInt("CollegueRelou3");
		if (RelouBool3 == 0) {
			Destroy (CollegueRelou3);
		}
		int RelouBool4 = PlayerPrefs.GetInt("CollegueRelou4");
		if (RelouBool4== 0) {
			Destroy (CollegueRelou4);
		}
		int RelouBool5 = PlayerPrefs.GetInt("CollegueRelou5");
		if (RelouBool5 == 0) {
			Destroy (CollegueRelou5);
		}
		int RelouBool6 = PlayerPrefs.GetInt("CollegueRelou6");
		if (RelouBool6 == 0) {
			Destroy (CollegueRelou6);
		}
		int RelouBool7 = PlayerPrefs.GetInt("CollegueRelou7");
		if (RelouBool7 == 0) {
			Destroy (CollegueRelou7);
		}
		int RelouBool8 = PlayerPrefs.GetInt("CollegueRelou8");
		if (RelouBool8== 0) {
			Destroy (CollegueRelou8);
		}
		int RelouBool9 = PlayerPrefs.GetInt("CollegueRelou9");
		if (RelouBool9 == 0) {
			Destroy (CollegueRelou9);
		}
		int RelouBool10 = PlayerPrefs.GetInt("CollegueRelou10");
		if (RelouBool10 == 0) {
			Destroy (CollegueRelou10);
		}
		int RelouBool11 = PlayerPrefs.GetInt("CollegueRelou11");
		if (RelouBool11 == 0) {
			Destroy (CollegueRelou11);
		}
		int RelouBool12 = PlayerPrefs.GetInt("CollegueRelou12");
		if (RelouBool12== 0) {
			Destroy (CollegueRelou12);
		}
		int RelouBool13 = PlayerPrefs.GetInt("CollegueRelou13");
		if (RelouBool13 == 0) {
			Destroy (CollegueRelou13);
		}
		int RelouBool14 = PlayerPrefs.GetInt("CollegueRelou14");
		if (RelouBool4 == 0) {
			Destroy (CollegueRelou14);
		}
		int RelouBool15 = PlayerPrefs.GetInt("CollegueRelou15");
		if (RelouBool15 == 0) {
			Destroy (CollegueRelou15);
		}
		int RelouBool16 = PlayerPrefs.GetInt("CollegueRelou16");
		if (RelouBool16== 0) {
			Destroy (CollegueRelou16);
		}
		int RelouBool17 = PlayerPrefs.GetInt("CollegueRelou17");
		if (RelouBool17 == 0) {
			Destroy (CollegueRelou17);
		}
		int RelouBool18 = PlayerPrefs.GetInt("CollegueRelou18");
		if (RelouBool18 == 0) {
			Destroy (CollegueRelou18);
		}
		int RelouBool19 = PlayerPrefs.GetInt("CollegueRelou19");
		if (RelouBool19 == 0) {
			Destroy (CollegueRelou19);
		}
		int RelouBool20 = PlayerPrefs.GetInt("CollegueRelou20");
		if (RelouBool20== 0) {
			Destroy (CollegueRelou20);
		}
		int RelouBool21 = PlayerPrefs.GetInt("CollegueRelou21");
		if (RelouBool21 == 0) {
			Destroy (CollegueRelou21);
		}
		int RelouBool22 = PlayerPrefs.GetInt("CollegueRelou22");
		if (RelouBool22 == 0) {
			Destroy (CollegueRelou22);
		}
		int RelouBool23 = PlayerPrefs.GetInt("CollegueRelou23");
		if (RelouBool23 == 0) {
			Destroy (CollegueRelou23);
		}
		int RelouBool24 = PlayerPrefs.GetInt("CollegueRelou24");
		if (RelouBool24 == 0) {
			Destroy (CollegueRelou24);
		}
			
		int RelouBool25 = PlayerPrefs.GetInt("CollegueRelou25");
		if (RelouBool25 == 0) {
			Destroy (CollegueRelou25);
		}
		int RelouBool26 = PlayerPrefs.GetInt("CollegueRelou26");
		if (RelouBool26 == 0) {
			Destroy (CollegueRelou26);
		}
		int RelouBool27 = PlayerPrefs.GetInt("CollegueRelou27");
		if (RelouBool27 == 0) {
			Destroy (CollegueRelou27);
		}
		int RelouBool28 = PlayerPrefs.GetInt("CollegueRelou28");
		if (RelouBool28== 0) {
			Destroy (CollegueRelou28);
		}

		*/
		 
		//CollegueCafé

		int CollegueCafeBool1 = PlayerPrefs.GetInt("CollegueCafe1");
		if (CollegueCafeBool1== 0) {
			Destroy (CollegueCafe1);
		}

		int CollegueCafeBool2 = PlayerPrefs.GetInt("CollegueCafe2");
		if (CollegueCafeBool2== 0) {
			Destroy (CollegueCafe2);
		}

		int CollegueCafeBool3 = PlayerPrefs.GetInt("CollegueCafe3");
		if (CollegueCafeBool3== 0) {
			Destroy (CollegueCafe3);
		}

		int CollegueCafeBool4 = PlayerPrefs.GetInt("CollegueCafe4");
		if (CollegueCafeBool4== 0) {
			Destroy (CollegueCafe4);
		}


		int CollegueCafeBool5 = PlayerPrefs.GetInt("CollegueCafe5");
		if (CollegueCafeBool5== 0) {
			Destroy (CollegueCafe5);
		}

		int CollegueCafeBool6 = PlayerPrefs.GetInt("CollegueCafe6");
		if (CollegueCafeBool6== 0) {
			Destroy (CollegueCafe6);
		}

		int CollegueCafeBool7 = PlayerPrefs.GetInt("CollegueCafe7");
		if (CollegueCafeBool7== 0) {
			Destroy (CollegueCafe7);
		}

		int CollegueCafeBool8 = PlayerPrefs.GetInt("CollegueCafe8");
		if (CollegueCafeBool8== 0) {
			Destroy (CollegueCafe8);
		}

		int CollegueCafeBool9 = PlayerPrefs.GetInt("CollegueCafe9");
		if (CollegueCafeBool9== 0) {
			Destroy (CollegueCafe9);
		}

		int CollegueCafeBool10 = PlayerPrefs.GetInt("CollegueCafe10");
		if (CollegueCafeBool10== 0) {
			Destroy (CollegueCafe10);
		}

		//CollegueToilettes

		int CollegueToilettesBool0 = PlayerPrefs.GetInt("CollegueToilettes0");
		if (CollegueToilettesBool0== 0) {
			Destroy (CollegueToilettes0);
		}

		int CollegueToilettesBool1 = PlayerPrefs.GetInt("CollegueToilettes1");
		if (CollegueToilettesBool0== 1) {
			Destroy (CollegueToilettes1);
		}
		int CollegueToilettesBool2 = PlayerPrefs.GetInt("CollegueToilettes2");
		if (CollegueToilettesBool2== 1) {
			Destroy (CollegueToilettes2);
		}

		int CollegueToilettesBool3 = PlayerPrefs.GetInt("CollegueToilettes3");
		if (CollegueToilettesBool3== 1) {
			Destroy (CollegueToilettes3);
		}

		int CollegueToilettesBool4 = PlayerPrefs.GetInt("CollegueToilettes4");
		if (CollegueToilettesBool4== 1) {
			Destroy (CollegueToilettes4);
		}
		int CollegueToilettesBool5 = PlayerPrefs.GetInt("CollegueToilettes5");
		if (CollegueToilettesBool5== 0) {
			Destroy (CollegueToilettes5);
		}

		int CollegueToilettesBool6 = PlayerPrefs.GetInt("CollegueToilettes6");
		if (CollegueToilettesBool6== 1) {
			Destroy (CollegueToilettes6);
		}
		int CollegueToilettesBool7 = PlayerPrefs.GetInt("CollegueToilettes7");
		if (CollegueToilettesBool7== 1) {
			Destroy (CollegueToilettes7);
		}

		int CollegueToilettesBool8 = PlayerPrefs.GetInt("CollegueToilettes8");
		if (CollegueToilettesBool8== 1) {
			Destroy (CollegueToilettes8);
		}

		int CollegueToilettesBool9 = PlayerPrefs.GetInt("CollegueToilettes9");
		if (CollegueToilettesBool9== 1) {
			Destroy (CollegueToilettes9);
		}
		int CollegueToilettesBool10 = PlayerPrefs.GetInt("CollegueToilettes10");
		if (CollegueToilettesBool10== 1) {
			Destroy (CollegueToilettes10);
		}

		int CollegueToilettesBool11 = PlayerPrefs.GetInt("CollegueToilettes11");
		if (CollegueToilettesBool11== 1) {
			Destroy (CollegueToilettes11);
		}

		int CollegueToilettesBool12 = PlayerPrefs.GetInt("CollegueToilettes12");
		if (CollegueToilettesBool12== 1) {
			Destroy (CollegueToilettes12);
		}
		int CollegueToilettesBool13 = PlayerPrefs.GetInt("CollegueToilettes13");
		if (CollegueToilettesBool13== 1) {
			Destroy (CollegueToilettes13);
		}

		//Garder la pos du joueur

		float posX = PlayerPrefs.GetFloat ("Axe X", -7.57f);
		float posY = PlayerPrefs.GetFloat ("Axe Y", -1.06f);

		player.transform.position = new Vector2 (posX, posY);


	}

}
