using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Interagir))]
public class SingletonJoueur : MonoBehaviour {

	public static GameObject joueur;
	public static Interagir interagir;

	void Awake() {
		joueur = gameObject;
		interagir = gameObject.GetComponent<Interagir> ();
	}
}
