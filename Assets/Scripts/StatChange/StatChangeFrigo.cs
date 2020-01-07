using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatChangeFrigo : MonoBehaviour, StatChangeElement {

	private bool used;

	public int modifForme;

	void Start () {
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
			Debug.Log ("use frigo");
		}

		StatManager.statManager.UpdateDisplay ();
	}

	public void ElementNotUsed() {
		if (!used) {
			Debug.Log ("frigo not used");
		}
	}
}
