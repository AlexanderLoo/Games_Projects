using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightingControl : MonoBehaviour {

	private float waitingTime = 4;
	private float randomTime ;


	void Update(){

		//asignamos un numero al azar entre 2 y 5
		randomTime = Random.Range (2, 5);
		//restamos el tiempo de espera por los segundos transcurridos y cuando el tiempo de espera se acabe prendemos las luces
		waitingTime -= Time.deltaTime;
		if (waitingTime <= 0) {
			Invoke ("Lighting",0);
			waitingTime = randomTime;
		}
	}

	void Lighting(){
		//rotamos la luz direccional para generar luz y en un corto periodo de tiempo las rotamos nuevamente para apagar las luces
		Quaternion isLighting = Quaternion.Euler (40, 124, 0);
		transform.rotation = isLighting;
		Invoke ("Darkness", 0.5f);
	}
	//función para apagar la luz
	void Darkness(){
		
		Quaternion isDark = Quaternion.Euler (-80, 124, 0);
		transform.rotation = isDark;
	}
}
