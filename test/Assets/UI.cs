using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour {

	public Explosion explosion;
	// Update is called once per frame
	void OnGUI () {
		if (GUI.Button(new Rect (10, 10, 50, 100), "Pinch")) {
			explosion.boom = true;
		}
	}
}
