using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public static Timer compo;

	public static int time = 440;
	private Text timerDisplay;
	private GameObject late;

	void Awake() {
		compo = this;
	}

	void Start () {
		timerDisplay = GetComponent<Text> ();
		StartCoroutine (Count ());

		late = GameObject.Find ("Late");
	}

	public static int[] Time2HM(int t) {
		int h = (int) t / 60;
		int m = t % 60;

		return new int[] {h, m};
	}

	public static int HMtoTime(int[] hm) {
		return hm[0]*60 + hm[1];
	}

	public static string HM2string(int[] hm) {
		string s;
		if (hm[0] < 10) {
			s = /*"0" +*/ hm [0].ToString();
		} else {
			s = hm [0].ToString();
		}
		if (hm [1] < 10) {
			s = s + " : 0" + hm [1].ToString();
		} else {
			s = s + " : " + hm [1].ToString();
		}
		return s;
	}


	void Update() {
		if (time > 480) {
			late.SetActive (true);
		} else {
			late.SetActive (false);
		}
	}


	private IEnumerator Count() {
		int[] heure;
		while(true) {
			time += 1;
			heure = Time2HM (time);
			timerDisplay.text = HM2string(heure);
			yield return new WaitForSecondsRealtime(3);
		}
	}
}
