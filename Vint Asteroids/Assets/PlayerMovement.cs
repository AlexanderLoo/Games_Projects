using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	private Rigidbody _rigidbody;
	public float speed;
	[System.NonSerialized]
	public float h, v;

	void Start(){
		_rigidbody = GetComponent<Rigidbody> ();
	}

	void Update(){

		h = Input.GetAxis ("Horizontal");
		v = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (h, 0, v);
		movement.Normalize ();
		movement *= speed;
		_rigidbody.velocity = movement;

		//Rotación, mirando la posición del mouse 
		Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		transform.LookAt(new Vector3(mousePos.x, transform.position.y, mousePos.z));
	}
}
