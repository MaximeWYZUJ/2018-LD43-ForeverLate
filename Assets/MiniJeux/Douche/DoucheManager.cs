using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoucheManager : MonoBehaviour {

	private ZoneDouche[] zd;

	void Start () {
		zd = GetComponentsInChildren<ZoneDouche> ();
		StartCoroutine (Check ());
	}
	
	IEnumerator Check() {
		while (true) {
			bool resultat = true;

			foreach (ZoneDouche zone in zd) {
				resultat = zone.done && resultat;
			}

			if (resultat) {
				SceneManager.LoadScene ("MainScene", LoadSceneMode.Single);
				break;
			}

			yield return new WaitForSecondsRealtime (1);
		}
	}
}
