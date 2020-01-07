using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mousse : MonoBehaviour {

	public Sprite[] spritesPossibles;

	void Start () {
		GetComponent<SpriteRenderer> ().sprite = spritesPossibles [Random.Range (0, spritesPossibles.Length)];
	}
}
