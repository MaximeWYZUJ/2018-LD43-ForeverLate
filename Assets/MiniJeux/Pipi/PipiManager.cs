using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PipiManager : MonoBehaviour {

	public GameObject[] schemes;

	private int currentScheme;
	private int nbSchemeComplete;

	void Start() {
		currentScheme = 0;
		nbSchemeComplete = 0;
	}

	public void Next() {
		nbSchemeComplete += 1;

		if (nbSchemeComplete < 3) {
			// On passe au suivant
			schemes [currentScheme].SetActive (false);
			currentScheme = (currentScheme + 1) % schemes.Length;
			schemes [currentScheme].SetActive (true);
			schemes [currentScheme].GetComponentInChildren<SchemeManager> ().Reset ();
		} else {
			SaveStat.qttForme += 10;
			SceneManager.LoadScene ("MainScene", LoadSceneMode.Single);
		}
	}
}
