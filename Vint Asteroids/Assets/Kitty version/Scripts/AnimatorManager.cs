using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour {

	private PlayerMovement _playerMovement;
	private Animator _animator;

	void Start(){

		_playerMovement = GetComponent<PlayerMovement> ();
		_animator = GetComponent<Animator> ();
	}

	void Update(){

		if (_playerMovement.h != 0 || _playerMovement.v != 0) {
			_animator.SetBool ("move", true);
		} else {
			_animator.SetBool ("move", false);
		}
	}
}
