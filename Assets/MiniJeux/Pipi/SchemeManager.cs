using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchemeManager : MonoBehaviour {

	private SchemePart[] sp;


	void Start () {
		sp = GetComponentsInChildren<SchemePart> ();

	}

	public void Reset() {
		foreach (SchemePart part in sp) {
			part.passed = false;
		}
	}

	public float Check() {
		int nbChecked = 0;
		int nbCheckedMax = sp.Length;

		foreach (SchemePart part in sp) {
			if (part.passed) {
				nbChecked += 1;
			}
		}

		Debug.Log ("Check : " + nbChecked.ToString () + " / " + nbCheckedMax.ToString ());

		return nbChecked/nbCheckedMax;
	}

	public bool IsStillInside() {
		bool b = false;
		foreach (SchemePart part in sp) {
			b = b || part.isInside;
		}
		return b;
	}
}
