using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {

	public int MoveSpeed;
	public float JumpHeight;
	private bool Doublejump;

	// Player grounded variables
	public Transform GroundCheck;
	public float GroundCheckRadius;
	public LayerMask WhatIsGround;
	private bool Grounded;
	private float MoveVelocity;

	// Use this for initialization
	void Start () {
		
	}
	
	void FixedUpdate () {
		Grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGround);
	}

	// Update is called once per frame
	void Update () {

		// This code makes the character jump
		if(Input.GetKeyDown (KeyCode.Space)&& Grounded){
			Jump();
		}

		//This code makes the character double jump

		if(Grounded){
			Doublejump = false;
		}

		if(Input.GetKeyDown (KeyCode.Space)&& !Doublejump && !Grounded){
			Jump();
			Doublejump = true;
		}

		//Non-stick player
		MoveVelocity = 0f;

		// This code makes the character move from side to side using the A and D keys
		if(Input.GetKey (KeyCode.D)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			MoveVelocity =  MoveSpeed;
		}

		if(Input.GetKey (KeyCode.A)){
			GetComponent<Rigidbody2D>().velocity = new Vector2( -MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			MoveVelocity = -MoveSpeed;
		}

		//flips the character
		if (GetComponent<Rigidbody2D>().velocity.x > 0)
			transform.localScale = new Vector3(0.4962814f,0.4535711f,1f);

		else if (GetComponent<Rigidbody2D>().velocity.x < 0)
			transform.localScale = new Vector3(-0.4962814f,0.4535711f,1f);

		GetComponent<Rigidbody2D>().velocity = new Vector2( MoveVelocity, GetComponent<Rigidbody2D>().velocity.y);

	}
	public void Jump(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
	}
		
}
