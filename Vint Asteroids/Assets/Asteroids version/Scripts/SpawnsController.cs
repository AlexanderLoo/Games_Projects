using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnsController : MonoBehaviour {

	public GameObject[] enemies;
	public Transform[] spawns;
	public int hazardCount;
	public float spawnWait;
	//posición minima y maxima en 'Y' y en 'X'
	public Vector2 positionInX, positionInY;

	void Start(){
		StartCoroutine (SpawnWaves ());
	}

	IEnumerator SpawnWaves(){

		//después de un segundo comienzan a aparacer los enemigos(tiempo de inicio)
		yield return new WaitForSeconds (1);

		while (true) {
			//aquí se maneja la cantidad de enemigos que se genera por cada wave
			for (int i = 0; i < hazardCount; i++) {
				TopBottomSpawns ();
				LeftRigthSpawns ();
			}
			// cantidad en segundos en espera para el siguiente wave(intervalo entre waves)
			yield return new WaitForSeconds (spawnWait);
		}
	}
	//hacer referencia al los spawns de arriba y de abajo
	void TopBottomSpawns(){
		//el ciclo for recorre el spawn de arriba y luego el de abajo, creamos una nueva posición y alteramos SOLO el eje 'X' para que sea random
		//también le damos una rotación random
		for (int i = 0; i < 2; i++) {
			Vector3 newPosition = spawns [i].position;
			newPosition.x = Random.Range (positionInX.x,positionInX.y);
			spawns [i].position = newPosition;
			Quaternion newQuaternion = Quaternion.Euler (0, 0, Random.Range (0, 360));
			//instanciamos por cada spawn, un enemigo aleatorio usando indices aleatorios, en una nueva posición y una rotación aleatoria(dirección de trayectoria)
			Instantiate (enemies [Random.Range (0, enemies.Length)], spawns [i].position, newQuaternion);
		}
	}
	//hace referencia a los spawns derecha e izquierda
	void LeftRigthSpawns(){
		//i es el número del indice del spawn(izquieda y luego derecha)
		for (int i = 2; i < 4; i++) {
			//En este caso no necesitamos variar el eje 'X' sino el 'Y' y hacerlo random y aplicamos rotación random también
			Vector3 newPosition = spawns [i].position;
			newPosition.y = Random.Range (positionInY.x,positionInY.y);
			spawns [i].position = newPosition;
			Quaternion newQuaternion = Quaternion.Euler (0, 0, Random.Range (0, 360));
			Instantiate (enemies [Random.Range (0, enemies.Length)], spawns [i].position, newQuaternion);
		}
	}
}
