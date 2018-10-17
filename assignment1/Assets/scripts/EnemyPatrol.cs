﻿using System.Collections;
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
	private bool HittingWall;

	// Edge Check
	private bool NotAtEdge;
	public Transform EdgeCheck;
	
	// Update is called once per frame
	void Update () {

		NotAtEdge = Physics2D.OverlapCircle(EdgeCheck.position, WallCheckRadius, WhatIsWall);

		HittingWall = Physics2D.OverlapCircle(WallCheck.position, WallCheckRadius, WhatIsWall);
		
		// If we've hit a wall or an edge, we turn left
		if (HittingWall || !NotAtEdge){
			MoveRight = !MoveRight;
		}

		//Vector3 means the x, y, and z axis
		//Vector2 is the x and y axis
		if (MoveRight){
			transform.localScale = new Vector3(-0.2f, 0.2f, 1f);
			GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}

		else {
			transform.localScale = new Vector3(-0.2f, 0.2f, 1f);
			GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}
	}
}
