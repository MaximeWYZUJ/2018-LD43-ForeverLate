using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dent : MonoBehaviour {

	private int nbDone;
	private bool moussed;
	public bool done;
	public GameObject prefabMousse;

	void Start() {
		moussed = false;
		done = false;
		nbDone = 0;
	}

	void OnTriggerEnter2D(Collider2D c) {
		nbDone +=1;
		done = (nbDone >= 17);
		if (!moussed && done) {
			moussed = true;
			GameObject m = Instantiate (prefabMousse, transform.position, Quaternion.identity);
		}

		GetComponentInParent<LavaboManager> ().Check ();
	}

}
