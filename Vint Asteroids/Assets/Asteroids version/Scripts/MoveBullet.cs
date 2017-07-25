using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour {

	private Rigidbody _rigidbody;
	public float speed;

	void Start(){

		_rigidbody = GetComponent<Rigidbody> ();
		_rigidbody.velocity = transform.up * speed;
	}
}
