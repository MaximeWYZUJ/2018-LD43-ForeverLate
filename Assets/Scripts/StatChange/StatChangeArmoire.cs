using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatChangeArmoire : MonoBehaviour, StatChangeElement {

	private bool used;
	private string name;

	void Start() {
		used = false;
	}

	public string Name {
		get { return gameObject.name; }
	}

	public bool Used {
		get { return used; }
	}

	public void UseElement() {
		Debug.Log ("use armoire");
	}

	public void ElementNotUsed() {
		if (!used) {
			Debug.Log ("armoire not used");
		}
	}
}