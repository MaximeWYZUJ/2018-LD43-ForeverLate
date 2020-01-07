using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LeaderBoardScript : MonoBehaviour {

	public Text bilanTxt;


	void Start () {
		string s = "\n\n";
		if (Bilan.J1Late) {
			s += "LATE\n";
		} else {
			s += "ON TIME !\n";
		}

		if (Bilan.bilanJ1) {
			s += "DONE\n\n";
		} else {
			s += "MISSED\n\n";
		}



		if (Bilan.J2Late) {
			s += "LATE\n";
		} else {
			s += "ON TIME !\n";
		}

		if (Bilan.bilanJ2) {
			s += "DONE\n\n";
		} else {
			s += "MISSED\n\n";
		}



		if (Bilan.J3Late) {
			s += "LATE\n";
		} else {
			s += "ON TIME !\n";
		}

		if (Bilan.bilanJ3) {
			s += "DONE\n\n";
		} else {
			s += "MISSED\n\n";
		}

		bilanTxt.text = s;
	}
	
	void OnMouseDown() {
		SceneManager.LoadScene ("TitleScreen", LoadSceneMode.Single);
	}
}
