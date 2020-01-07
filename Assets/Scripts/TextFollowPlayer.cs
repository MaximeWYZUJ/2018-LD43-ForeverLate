using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFollowPlayer : MonoBehaviour {

	private RectTransform tr;
	private RectTransform canvasRect;
	private Camera cam;

	public float xOffset;
	public float yOffset;

	void Start () {
		tr = GetComponent<RectTransform> ();
		canvasRect = GameObject.Find ("Canvas").GetComponent<RectTransform> ();
		cam = GameObject.Find ("Main Camera").GetComponent<Camera>();
	}
	

	void Update () {
		Vector2 viewportPosition = cam.WorldToViewportPoint (SingletonJoueur.joueur.transform.position);
		Vector2 screenPosition = new Vector2(
			((viewportPosition.x*canvasRect.sizeDelta.x)-(canvasRect.sizeDelta.x*0.5f)),
			((viewportPosition.y*canvasRect.sizeDelta.y)-(canvasRect.sizeDelta.y*0.5f)));

		screenPosition = new Vector2 (screenPosition.x + xOffset, screenPosition.y + yOffset);

		tr.anchoredPosition = screenPosition;
	}
}
