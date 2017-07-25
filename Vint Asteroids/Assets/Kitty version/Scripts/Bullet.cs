using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float speed;

	void Update(){
		transform.Translate (Vector3.forward * speed * Time.deltaTime);
		Invoke ("DestroyBullet", 1);
	}

	void DestroyBullet(){

		Destroy (gameObject);
	}
}
