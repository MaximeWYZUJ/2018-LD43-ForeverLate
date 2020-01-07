using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBureau : MonoBehaviour {

	private BureauManager bm;
	public bool done;

	public Color jaune;
	public Color rouge;
	public Color transparent;

	private bool used;

	void Start() {
		done = false;
		used = false;
		bm = GetComponentInParent<BureauManager> ();
		GetComponent<SpriteRenderer> ().color = transparent;
	}

	void OnMouseDown() {
		if (bm.IsInsideATrouver (this)) {
			GetComponent<SpriteRenderer> ().color = jaune;
			done = true;
		} else {
			GetComponent<SpriteRenderer> ().color = rouge;
			bm.erreurs += 1;
		}
		used = true;
	}
}
