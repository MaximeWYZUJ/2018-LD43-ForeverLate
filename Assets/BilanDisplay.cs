using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BilanDisplay : MonoBehaviour {

	public GameObject[] animJ1;
	public GameObject[] animJ2;
	public GameObject[] animJ3;

	void Start() {
		switch (Bilan.compteurJour) {
		case 1:
			{
				animJ1 [0].SetActive (!Bilan.bilanJ1);
				animJ1 [1].SetActive (Bilan.bilanJ1);
			}
			break;
		
		case 2:
			{
				animJ2 [0].SetActive (!Bilan.bilanJ2);
				animJ2 [1].SetActive (Bilan.bilanJ2);
			}
			break;
		
		case 3:
			{
				animJ3 [0].SetActive (!Bilan.bilanJ3);
				animJ3 [1].SetActive (Bilan.bilanJ3);
			}
			break;
		}
	}
}
