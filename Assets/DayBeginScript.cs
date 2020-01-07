using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DayBeginScript : MonoBehaviour {

	public float tempsAvantTransition;

	private GameObject dayText, hourText;

	void Start() {
		dayText = GameObject.Find ("FadeDay");
		hourText = GameObject.Find ("FadeHour");

		string s = "\nDON'T BE LATE !";

		if (Bilan.compteurJour == 1) {
			dayText.GetComponent<Text> ().text = "MONDAY" + s;
		} else if (Bilan.compteurJour == 2) {
			dayText.GetComponent<Text> ().text = "TUESDAY" + s;
		} else {
			dayText.GetComponent<Text> ().text = "WEDNESDAY" + s;
		}

		hourText.GetComponent<Text> ().text = Timer.HM2string (Timer.Time2HM (Timer.time));

		StartCoroutine (Transition ());
	}

	private IEnumerator Transition() {
		yield return new WaitForSecondsRealtime (tempsAvantTransition);
		SceneManager.LoadScene ("MainScene", LoadSceneMode.Single);
	}
}
