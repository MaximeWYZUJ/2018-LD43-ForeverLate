using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LavaboManager : MonoBehaviour {

	private Dent[] dents;

	void Start () {
		dents = GetComponentsInChildren<Dent> ();
	}
	
	public void Check() {
		bool b = true;

		foreach (Dent d in dents) {
			b = b && d.done;
		}

		if (b) {
			SceneManager.LoadScene ("MainScene", LoadSceneMode.Single);
		}
	}
}
