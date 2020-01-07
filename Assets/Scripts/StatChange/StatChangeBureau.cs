using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StatChangeBureau : MonoBehaviour, StatChangeElement {

	private bool used;
	private string name;

	public int modifAssiduiteDone;
	public int modifAssiduiteNotDone;
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
			s [2].Change (modifAssiduiteDone);
			s [3].Change (modifForme);
			used = true;
			Bilan.bureauUsed = true;
			Debug.Log ("use bureau");
			StatManager.statManager.Save ();
			SceneManager.LoadScene ("BureauScene", LoadSceneMode.Single);
		}

		StatManager.statManager.UpdateDisplay ();
	}

	public void ElementNotUsed() {
		if (!used) {
			Stat[] s = StatManager.statManager.Stats;
			s [2].Change (modifAssiduiteNotDone);

			Debug.Log ("bureau not used");
		}
	}
}
