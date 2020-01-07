using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement : MonoBehaviour {

	private Rigidbody2D rb;

	public GameObject idleAnim, walkAnim;

	public float force;
	public float velocityMax;
	public KeyCode gauche;
	public KeyCode droite;
	public KeyCode haut;
	public KeyCode bas;

	private float xscale;
	private bool dansEscalier;

	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D> ();
		xscale = transform.localScale.x;

		transform.position = new Vector3 (SaveStat.Xposition, SaveStat.Yposition, -1);
	}
	

	void Update () {
		if (Input.GetKeyDown (gauche) || Input.GetKeyDown (droite)) {
			rb.velocity = Vector2.zero;
		}

		if (Input.GetKey (gauche)) {
			rb.AddForce(new Vector2(-force, 0));
			transform.localScale = new Vector3 (xscale, transform.localScale.y, transform.localScale.z);
		}

		if (Input.GetKey (droite)) {
			rb.AddForce(new Vector2 (force, 0));
			transform.localScale = new Vector3 (-xscale, transform.localScale.y, transform.localScale.z);
		}

		if (dansEscalier) {
			if (Input.GetKeyDown (haut) || Input.GetKeyDown (bas)) {
				rb.velocity = Vector2.zero;
			}

			if (Input.GetKey (haut)) {
				rb.AddForce (new Vector2 (0, force));
			}

			if (Input.GetKey (bas)) {
				rb.AddForce (new Vector2 (0, -force));
			}
		}

		if (Input.GetKey (gauche) || Input.GetKey (droite) || Input.GetKey (haut) || Input.GetKey (bas)) {
			walkAnim.SetActive (true);
			idleAnim.SetActive (false);
		} else {
			walkAnim.SetActive (false);
			idleAnim.SetActive (true);
		}

		// Cap vitesse
		if (rb.velocity.magnitude > velocityMax) {
			rb.velocity = rb.velocity.normalized * velocityMax;
		}
	}


	void OnTriggerEnter2D(Collider2D c) {
		if (string.Equals ("escalier", c.gameObject.tag)) {
			dansEscalier = true;
			rb.gravityScale = 0.5f;
		}
	}

	void OnTriggerExit2D(Collider2D c) {
		if (string.Equals("escalier", c.gameObject.tag)) {
			dansEscalier = false;
			rb.gravityScale = 1;
		}
	}
}
