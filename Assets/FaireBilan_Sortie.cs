using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FaireBilan_Sortie : MonoBehaviour, StatChangeElement {

	private bool used;

	void Start () {
		used = false;
	}

	public bool Used {
		get { return used; }
	}

	public string Name {
		get { return gameObject.name; }
	}

	public void UseElement() {
		StatManager.statManager.Save ();
		GetComponentInParent<FaireBilan> ().Work ();
		SceneManager.LoadScene ("NightScene", LoadSceneMode.Single);
	}
	
	public void ElementNotUsed() {}

}
