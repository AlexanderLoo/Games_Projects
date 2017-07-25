using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour {


	public Image[] lives;
	public int life = 3;
	private int currentLife;
	private int livesIndex = 2;

	void Start(){
		
		//currentLife = life;
	}

	/*void Update(){

		if (life < currentLife) {
			lives [livesIndex].enabled = false;
			currentLife = life;
			livesIndex--;
			transform.position = Vector3.zero;
		}
		if (life > currentLife) {
			++livesIndex;
			lives [livesIndex].enabled = true;
			currentLife = life;
		}
	}*/
}
