using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curseur : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		Vector3 mouse = Input.mousePosition;
		mouse.z = 10;

		transform.position = Camera.main.ScreenToWorldPoint (mouse);
	}

}
