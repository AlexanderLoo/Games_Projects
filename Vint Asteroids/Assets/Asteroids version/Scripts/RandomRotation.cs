﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotation : MonoBehaviour {

	public float tumble;
	private Rigidbody _rigidbody;

	void Start(){

		_rigidbody = GetComponent<Rigidbody> ();
		_rigidbody.angularVelocity = Random.insideUnitSphere * tumble;
	}

}
