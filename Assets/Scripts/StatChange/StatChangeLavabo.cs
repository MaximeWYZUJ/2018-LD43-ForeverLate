using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StatChangeLavabo : MonoBehaviour, StatChangeElement {

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
			Stat[] s = StatManager.statManager.Stats;
			s [1].Change (modifHygiene);
			used = true;
			Bilan.lavaboUsed = true;
			Debug.Log ("use lavabo");
			StatManager.statManager.Save ();
			SceneManager.LoadScene ("LavaboScene", LoadSceneMode.Single);
		}

		StatManager.statManager.UpdateDisplay ();
	}

	public void ElementNotUsed() {
		if (!used) {
			Stat[] s = StatManager.statManager.Stats;
			s [0].Change (modifSocial);
			used = true;
			Debug.Log ("lavabo not used");
		}

		StatManager.statManager.UpdateDisplay ();
	}
}
