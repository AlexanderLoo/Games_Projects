using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegamanAnimations : MonoBehaviour {

	private Animator _animator;
	private PlayerMovement _playerMovement;

	void Start(){
		_animator = GetComponent<Animator> ();
		_playerMovement = GetComponent<PlayerMovement> ();
	}
	void Update(){

		_animator.SetFloat ("move", Mathf.Abs (_playerMovement.h));
		_animator.SetBool ("isGrounded", _playerMovement.isGrounded);
		_animator.SetFloat ("verticalSpeed", _playerMovement.verticalSpeed);
	}
}
