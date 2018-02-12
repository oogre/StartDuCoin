using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {
	public GameObject obj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.localPosition;
		print(obj.transform);
		pos.y = obj.transform.localPosition.y;
		transform.localPosition = pos;
	}
}
