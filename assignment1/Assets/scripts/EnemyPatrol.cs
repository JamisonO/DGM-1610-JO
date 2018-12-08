using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour {

	// Movement Variables
	public float MoveSpeed;
	public bool MoveRight;

	// Wall Check
	public Transform WallCheck;
	public float WallCheckRadius;
	public LayerMask WhatIsWall;
	[SerializeField]
	private bool HittingWall;

	// Edge Check
	
	
	void OnTriggerEnter2D(Collider2D other){
			if(other.name == "Player") {
				if (MoveRight){
					MoveRight = false;
				}

				else {
					MoveRight = true;
				}
			}
		}

	// Update is called once per frame
	void Update () {

		HittingWall = Physics2D.OverlapCircle(WallCheck.position, WallCheckRadius, WhatIsWall);
		
		// If we've hit a wall or an edge, we turn left
		if (HittingWall){
			MoveRight = !MoveRight;
		}

		//Vector3 means the x, y, and z axis
		//Vector2 is the x and y axis
		if (MoveRight){
			transform.localScale = new Vector3(-0.5414006f, 0.5414006f, 0.5414006f);
			GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}

		else {
			transform.localScale = new Vector3(0.5414006f, 0.5414006f, 0.5414006f);
			GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}
	}
}
