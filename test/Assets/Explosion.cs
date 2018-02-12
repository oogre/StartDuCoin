using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {
	public GameObject bomb;
	public float power = 10f;
	public float radius = 5f;
	public float upForce = 1f;
	public bool boom = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (boom) {
			boom = false;
			Detonate ();
			Detonate ();
		}
	}

	void Detonate(){
		Vector3 explosionPosition = bomb.transform.position;
		float a = Random.value * Mathf.PI * 2f;
		explosionPosition += new Vector3 (0.5f * Mathf.Cos(a), 0, 0.5f * Mathf.Sin(a));

		Collider[] colliders = Physics.OverlapSphere (explosionPosition, radius);
		foreach (Collider hit in colliders) {
			Rigidbody rib = hit.GetComponent<Rigidbody> ();
			if (rib != null) {
				rib.AddExplosionForce (power, explosionPosition, radius, upForce, ForceMode.Impulse);
			}
		}
	}
}
