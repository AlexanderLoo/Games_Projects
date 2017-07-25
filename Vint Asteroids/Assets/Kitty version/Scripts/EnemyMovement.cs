using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	private GameObject _player;
	private Rigidbody _rigidbody;
	private Vector3 dir;
	public float speed;

	void Start(){

		_player = GameObject.FindGameObjectWithTag ("Player");
		_rigidbody = GetComponent<Rigidbody> ();
	}

	void Update(){
		
		dir = _player.transform.position - transform.position;
		dir.Normalize ();
		dir *= speed;
		transform.LookAt (_player.transform.position);
	}

	void FixedUpdate(){

		_rigidbody.velocity = dir;
	}
}
