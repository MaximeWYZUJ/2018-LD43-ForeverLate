using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interagir : MonoBehaviour {

	public KeyCode interactInput;
	public Text tInteraction;


	private bool interactionPossible;
	private GameObject lastObjInteractif;


	void OnTriggerEnter2D(Collider2D c) {
		if (!string.Equals ("escalier", c.gameObject.tag)) {
			interactionPossible = true;
			lastObjInteractif = c.gameObject;
		}
	}

	void OnTriggerExit2D(Collider2D c) {
		if (!string.Equals ("escalier", c.gameObject.tag)) {
			interactionPossible = false;
			lastObjInteractif = null;
		}
	}

	void Update() {
		if (interactionPossible && Input.GetKeyDown(interactInput)) {
			lastObjInteractif.GetComponent<StatChangeElement> ().UseElement ();
		}
	}
}
