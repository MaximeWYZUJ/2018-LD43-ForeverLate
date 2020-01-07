using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMousse : MonoBehaviour {

	public GameObject prefabMousse;
	private bool onDent;

	void Start () {
		onDent = false;
		StartCoroutine (DropMousse ());
	}
	
	IEnumerator DropMousse() {
		while (true) {
			if (!onDent) {
				Instantiate (prefabMousse, transform.position, Quaternion.identity);
			}
			yield return new WaitForSecondsRealtime (1);
		}
	}

	void OnTriggerStay2D(Collider2D c) {
		onDent = true;
	}

	void OnTriggerExit2D(Collider2D c) {
		onDent = false;
	}
}
