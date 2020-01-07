using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionElement : MonoBehaviour {

	private Text t;

	public string text;

	void Start() {
		t = SingletonJoueur.interagir.tInteraction;
	}

	void OnTriggerEnter2D(Collider2D c) {
		t.enabled = true;
		t.text = text;
	}

	void OnTriggerExit2D(Collider2D c) {
		t.enabled = false;

	}
}
