using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WasteTime : MonoBehaviour {


	void Start () {
		StartCoroutine (Countdown ());
	}
	
	public IEnumerator Countdown() {
		while(true) {
			Timer.time += 1;
			yield return new WaitForSecondsRealtime(4);
		}
	}
}
