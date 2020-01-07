using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StatChangeDouche : MonoBehaviour, StatChangeElement {

	private bool used;

	public int modifHygiene;

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
			s [1].Change (modifHygiene);
			used = true;
			Bilan.doucheUsed = true;
			Debug.Log ("use douche");
			StatManager.statManager.Save ();
			SceneManager.LoadScene ("DoucheScene", LoadSceneMode.Single);
		}

		StatManager.statManager.UpdateDisplay ();
	}

	public void ElementNotUsed() {
		if (!used) {
			Debug.Log ("douche not used");
		}
	}
}
