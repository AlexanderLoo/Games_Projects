using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	private Rigidbody2D _rigidbody;
	private SpriteRenderer _spriteRenderer;
	private BoxCollider2D _boxCollider;

	private bool jump;

	public float verticalSpeed;
	public float h;
	public float speed;
	public float gravity;
	public float jumpForce;
	public bool isGrounded;
	public float rayLenght;
	public LayerMask _allMask;

	void Start(){

		_rigidbody = GetComponent<Rigidbody2D> ();
		_boxCollider = GetComponent<BoxCollider2D> ();
		_spriteRenderer = GetComponent<SpriteRenderer> ();
	}

	void Update(){
		
		 h = Input.GetAxis ("Horizontal");
		jump = Input.GetButton ("Jump");
		ManageFlipping ();
	}

	void FixedUpdate(){

		Movement();
	}

	void Movement(){

		Vector3 boxSize = new Vector3 (_boxCollider.size.x,_boxCollider.size.y,0);
		RaycastHit2D hitInfo = Physics2D.BoxCast (transform.position, boxSize, 0, Vector3.down, rayLenght, _allMask.value);
		if (hitInfo.collider != null) {
			isGrounded = true;
		} else {
			isGrounded = false;
		}
		if (isGrounded) {
			verticalSpeed = -0.1f;
			if (jump) {
				verticalSpeed = jumpForce;
			}
		} else {
			verticalSpeed += gravity * Time.deltaTime;
		}
		Vector3 moveVector = new Vector3 (h * speed, verticalSpeed, 0);
		_rigidbody.velocity = moveVector;
	}
	void ManageFlipping(){
		if (h > 0) {
			_spriteRenderer.flipX = false;
		}
		if(h < 0){
			_spriteRenderer.flipX = true;
		}
	}
	void OnDrawGizmos(){

		if (isGrounded) {
			Gizmos.color = Color.green;
		} else {
			Gizmos.color = Color.red;
		}
		Vector3 boxSize = new Vector3 (_boxCollider.size.x,_boxCollider.size.y);
		Gizmos.DrawWireCube (transform.position, boxSize);
		Gizmos.DrawWireCube (transform.position+ (Vector3.down * rayLenght) ,boxSize);
	}
}
