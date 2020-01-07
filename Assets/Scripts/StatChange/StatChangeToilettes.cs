using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StatChangeToilettes : MonoBehaviour, StatChangeElement {

	private bool used;

	public int modifHygiene;
	public int modifSocial;

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
			Debug.Log ("toilettes used");
			StatManager.statManager.Save ();
			SceneManager.LoadScene ("pipiScene", LoadSceneMode.Single);
		}
	}

	public void ElementNotUsed() {
		if (!used) {
			Stat[] s = StatManager.statManager.Stats;
			s [0].Change (modifSocial);
			s [1].Change (modifHygiene);
			used = true;
			Bilan.toilettesUsed = true;
			Debug.Log ("toilettes not used");
		}

		StatManager.statManager.UpdateDisplay ();
	}
}
