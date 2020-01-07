using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatManager : MonoBehaviour {

	public static StatManager statManager;

	private Stat[] stats;
	public Text t;

	public Stat chat;


	void Awake () {
		statManager = this;
	}

	void Start() {
		
		Stat social = ScriptableObject.CreateInstance<Stat> ();
		social.Init ("Social", SaveStat.qttSocial, 100, StatCode.social);

		Stat hygiene = ScriptableObject.CreateInstance<Stat> ();
		hygiene.Init ("Hygiène", SaveStat.qttHygiene, 100, StatCode.hygiene);

		Stat assiduite = ScriptableObject.CreateInstance<Stat> ();
		assiduite.Init ("Assiduité", SaveStat.qttAssiduite, 100, StatCode.assiduite);

		Stat forme = ScriptableObject.CreateInstance<Stat> ();
		forme.Init ("Bien être", SaveStat.qttForme, 100, StatCode.forme);

		stats = new Stat[] { social, hygiene, assiduite, forme };

		chat = ScriptableObject.CreateInstance<Stat> ();
		chat.Init ("Chat", SaveStat.qttChat, 5, StatCode.chat);
	}

	public void UpdateDisplay() {/*
		Debug.Log ("update display");
		string s = "Stats :\n";
		foreach (Stat stat in stats) {
			s = s + stat.nom + " : " + stat.qtt.ToString () + "\n";
		}
		t.text = s;*/
	}

	public Stat[] Stats {
		get { return stats; }
	}


	public void Save() {
		SaveStat.qttSocial = stats [0].qtt;
		SaveStat.qttHygiene = stats [1].qtt;
		SaveStat.qttAssiduite = stats [2].qtt;
		SaveStat.qttForme = stats [3].qtt;
		SaveStat.qttChat = chat.qtt;

		SaveStat.Xposition = SingletonJoueur.joueur.transform.position.x;
		SaveStat.Yposition = SingletonJoueur.joueur.transform.position.y;
	}

}



public class Stat : ScriptableObject {

	public string nom;
	public int qtt;
	public StatCode code;

	private int max;

	public void Init(string n, int qtt, int max, StatCode code) {
		this.nom = n;
		this.max = max;
		this.qtt = qtt;
	}

	public void Change(int x) {
		qtt += x;
		if (x > 0) {
			qtt = Mathf.Min (qtt, max);
		} else {
			qtt = Mathf.Max (qtt, 0);
		}
	}

	public string Stat2String() {
		return nom + " : " + qtt.ToString ();
	}
}

public enum StatCode { social, hygiene, assiduite, forme , chat};


public static class SaveStat {

	public static int qttSocial = 50;
	public static int qttHygiene = 50;
	public static int qttAssiduite = 50;
	public static int qttForme = 50;
	public static int qttChat = 3;

	public static float Xposition = 2.35f;
	public static float Yposition = 3.02f;
}