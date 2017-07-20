using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	private Transform target;
	private Vector3 offset;

	public float followSpeed;

	void Start(){

		target = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform> ();
		offset = transform.position - target.position;
	}

	void Update(){

		//transform.position = target.position + offset;

		Vector3 newPosition= target.position + offset;
		Vector3 finalPosition = Vector3.Lerp (transform.position, newPosition, Time.deltaTime * followSpeed);
		transform.position = finalPosition;
	}
}
