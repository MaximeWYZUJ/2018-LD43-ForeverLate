using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaireBilan : MonoBehaviour {

	private StatChangeElement[] objetsUtilisables;


	void Start() {
		objetsUtilisables = GetComponentsInChildren<StatChangeElement> ();
	}

	private StatChangeElement TablFind(string nom) {
		StatChangeElement elmt = null;

		foreach (StatChangeElement e in objetsUtilisables) {
			if (string.Equals (e.Name, nom)) {
				elmt = e;
			}
		}

		return elmt;
	}

	public void Work() {
		switch (Bilan.compteurJour) {
		case 1:
			{
				StatChangeElement douche = TablFind ("Douche");
				StatChangeElement lavabo = TablFind ("Lavabo");

				Bilan.bilanJ1 = (Bilan.doucheUsed || Bilan.lavaboUsed);

				if (Timer.time < 480) {
					Bilan.J1Late = true;
				} else {
					Bilan.J1Late = false;
				}
			}
			break;
		
		case 2:
			{
				StatChangeElement bureau = TablFind ("Bureau");

				Bilan.bilanJ2 = Bilan.bureauUsed;

				if (Timer.time < 480) {
					Bilan.J2Late = true;
				} else {
					Bilan.J2Late = false;
				}
			}
			break;
		
		case 3:
			{
				if (Timer.time < 480) {
					Bilan.J3Late = true;
				} else {
					Bilan.J3Late = false;
				}
			}
			break;
		}
	
	}

}
