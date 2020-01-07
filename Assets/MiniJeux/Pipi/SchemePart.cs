using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchemePart : MonoBehaviour {

	public bool passed;
	public bool isInside;

	private SchemeManager manager;

	void Start () {
		passed = false;
		manager = GetComponentInParent<SchemeManager> ();
	}
	
	void OnTriggerExit2D(Collider2D c) {
		isInside = false;
		if (!manager.IsStillInside ()) {
			manager.Check ();
			manager.Reset ();
		}

		if (manager.Check () == 1f) {
			Debug.Log ("next");
			GameObject.Find ("GameManager").GetComponent<PipiManager> ().Next ();
		}
	}

	void OnTriggerEnter2D(Collider2D c) {
		passed = true;
		isInside = true;
	}
}
