using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {

	public GameObject bullet;
	public Transform shotSpawn;
	private AudioSource audioShot;

	void Start(){
		audioShot = GetComponent<AudioSource> ();
	}

	void Update(){

		bool shot = Input.GetButtonDown ("Fire1");
		if (shot) {
			audioShot.Play ();
			Instantiate (bullet, shotSpawn.position, shotSpawn.rotation);
		}
	}
}
