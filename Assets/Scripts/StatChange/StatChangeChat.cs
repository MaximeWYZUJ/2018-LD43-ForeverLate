using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatChangeChat : MonoBehaviour, StatChangeElement {

	private bool used;
	private string name;

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
		Stat s = StatManager.statManager.chat;

		if (!used && s.qtt > 0) {	// on verifie que le chat est pas mort de faim
			s.Change (1);
			used = true;
			Debug.Log ("use chat");
		}

		StatManager.statManager.UpdateDisplay ();
	}

	public void ElementNotUsed() {
		Stat s = StatManager.statManager.chat;

		if (!used && s.qtt > 0) {
			s.Change (-1);

			Debug.Log ("chat not used");
		}
	}
}
