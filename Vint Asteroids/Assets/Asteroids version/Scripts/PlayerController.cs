using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody _rigidbody;

	private bool moveForward;

	public float rotationSpeed, moveForce;

	void Start(){

		_rigidbody = GetComponent<Rigidbody> ();
	}

	void Update(){

		float rotation = Input.GetAxis("Rotation");
		moveForward = Input.GetButton ("Forward");
		//rotamos al player usando los inputs 'A' y ' D', también con las teclas direccionales derecha e izquierda
		transform.Rotate (0, 0, rotation * rotationSpeed);
	}

	void FixedUpdate(){

		//cada vez que se pulsa la tecle 'W' se agrega fuerza física al player en la dirección de adelante(Y)
		if (moveForward) {
			_rigidbody.AddForce (transform.up * moveForce);
		}
	}

}
