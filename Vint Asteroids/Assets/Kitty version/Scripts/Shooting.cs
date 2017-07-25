using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

	public GameObject bullet;
	public Transform shotSpawn;
	public float fireRate;
	private float nextFire;

	void Update(){

		bool shot = Input.GetButton ("Fire1");

		if (shot && Time.time > nextFire) {
			Instantiate (bullet, shotSpawn.position, shotSpawn.rotation);
			nextFire = fireRate + Time.time;
		}
	}
}
