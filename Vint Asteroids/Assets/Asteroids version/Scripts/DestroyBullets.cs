using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullets : MonoBehaviour {

	//Al salir del trigger las balas se destruyen
	void OnTriggerExit(Collider other){

		if (other.CompareTag ("Bullet")) {
			Destroy (other.gameObject);
		}
	}
}
