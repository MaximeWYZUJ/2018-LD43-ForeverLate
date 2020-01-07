using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneDouche : MonoBehaviour {

	public bool done;

	public Sprite[] moussePossible;
	public Sprite zoneChaude;
	public Sprite zoneFroide;

	private RandomTemperature temp;
	private SpriteRenderer sr;

	void Start () {
		done = false;
		temp = GetComponentInParent<RandomTemperature> ();
		sr = GetComponent<SpriteRenderer> ();
		sr.sprite = moussePossible [Random.Range (0, moussePossible.Length)];
	}
	
	void OnTriggerEnter2D(Collider2D c) {
		if (temp.temperature == -1) {
			sr.enabled = true;
			sr.sprite = zoneFroide;
			done = false;
		} else if (temp.temperature == 0) {
			sr.enabled = false;
			done = true;
		} else {
			done = false;
			sr.enabled = true;
			sr.sprite = zoneChaude;
		}
	}
}
