using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StatChangeLit : MonoBehaviour, StatChangeElement {

	private bool used;

	public int modifForme;

	void Start() {
		used = false;
	}

	public bool Used {
		get { return used; }
	}

	public string Name {
		get { return gameObject.name; }
	}

	public void UseElement() {
		if (!used) {
			Stat[] s = StatManager.statManager.Stats;
			s [3].Change (modifForme);
			used = true;

			Bilan.bureauUsed = false;
			Bilan.doucheUsed = false;
			Bilan.lavaboUsed = false;
			Bilan.toilettesUsed = false;
			Timer.time = 450 + Random.Range(0, 6);
			Bilan.compteurJour += 1;
			StatManager.statManager.Save ();

			if (Bilan.compteurJour <= 3) {
				SceneManager.LoadScene ("DayBegin", LoadSceneMode.Single);
			} else {
				SceneManager.LoadScene ("LeaderBoard", LoadSceneMode.Single);
			}
		}

		StatManager.statManager.UpdateDisplay ();
	}

	public void ElementNotUsed() {
		if (!used) {
			Debug.Log ("lit not used");
		}
	}
}
