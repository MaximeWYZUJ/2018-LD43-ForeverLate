using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTemperature : MonoBehaviour {

	public int temperature; // -1, 0 ou 1
	public Sprite[] spriteT;
	public GameObject UItemp;

	void Start () {
		temperature = 0;
		StartCoroutine (ChangeTemp ());
	}
	
	IEnumerator ChangeTemp() {
		while (true) {
			int previousT = temperature;
			while (previousT == temperature) {
				temperature = Random.Range ((int)-1, (int)2);
			}

			UItemp.GetComponent<SpriteRenderer> ().sprite = spriteT [temperature + 1];
				
			yield return new WaitForSecondsRealtime (Random.Range(3f, 5f));
		}
	}
}
