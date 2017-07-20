using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour {

	public float moveSpeed;
	public float rotationSpeed;

	public Transform shotSpawn;
	//lista de balas cromáticas
	public GameObject[] Bullet;
	private int bulletIndex;
	//estados de colores
	private bool _yellow,_red,_blue;

	void Start(){
		
	}

	void Update(){

		float move = Input.GetAxis ("Vertical");
		float rotate = Input.GetAxis ("Horizontal");
		//mover al player adelante y atrás
		transform.Translate (Vector3.forward * moveSpeed * move * Time.deltaTime);
		//rotar al player derecha e izquierda
		transform.Rotate (0, rotate * rotationSpeed, 0);
		ShotController ();
	}

	void ShotController(){

		//tecla de disparo
		bool shot = Input.GetKeyDown (KeyCode.K);
		//teclas de selección de colores
		bool yellowKey = Input.GetKeyDown (KeyCode.I);
		if (yellowKey) {
			_yellow = !_yellow;
		}
		bool redKey = Input.GetKeyDown (KeyCode.J);
		if (redKey) {
			_red = !_red;
		}
		bool blueKey = Input.GetKeyDown (KeyCode.L);
		if (blueKey) {
			_blue = !_blue;
		}
		//tecla de confirmar color de bala
		bool selectionKey = Input.GetKeyDown(KeyCode.Space);

		if (selectionKey) {
			if (_yellow) {
				bulletIndex = 0;
			}
			if (_red) {
				bulletIndex = 1;
			}
			if (_blue) {
				bulletIndex = 2;
			}
			if (_yellow && _red) {
				bulletIndex = 3;
			}
			if (_yellow && _blue) {
				bulletIndex = 4;
			}
			if (_red && _blue) {
				bulletIndex = 5;
			}

		}
		if (shot) {
			Instantiate (Bullet [bulletIndex], shotSpawn.position, shotSpawn.rotation);
		}
	}

}
