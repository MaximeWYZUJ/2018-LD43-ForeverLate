using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BureauManager : MonoBehaviour {

	public TextBureau[] textesPossibles;
	private TextBureau[] texteATrouver;

	public Text UItext;
	public int erreurs;

	void Start () {
		texteATrouver = new TextBureau[5];
		int indiceDepart = Random.Range (0, textesPossibles.Length);

		for (int i = 0; i < 5; i++) {
			texteATrouver [i] = textesPossibles [(i + indiceDepart) % textesPossibles.Length];
			UItext.text += texteATrouver [i].name + "\n";
		}
	}

	public bool IsInsideATrouver(TextBureau text) {
		bool b = false;
		foreach (TextBureau tb in texteATrouver) {
			b = b || (tb.Equals (text));
		}
		return b;
	}
	
	public IEnumerator Check() {
		while(true) {
			bool b = true;
			foreach(TextBureau tb in texteATrouver) {
				b = b && tb.done;
			}

			if (b) {
				SceneManager.LoadScene ("MainScene", LoadSceneMode.Single);
			}
		}
	}
}
