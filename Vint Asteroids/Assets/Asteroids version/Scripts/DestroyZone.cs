using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone : MonoBehaviour {

	//Los enemigos que salen del Trigger se destruyen
	void OnTriggerExit(Collider other){

		if (other.CompareTag ("Enemy")) {

			Destroy (other.gameObject);
		}
	}
}
