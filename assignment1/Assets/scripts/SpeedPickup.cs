using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPickup : MonoBehaviour {

	public CharacterMove CharacterMove;

	// Use this for initialization
	void Start () {
		CharacterMove = FindObjectOfType <CharacterMove>();
	}

	void OnTriggerEnter2D (Collider2D other){
		if(other.name == "Player"){

		CharacterMove.SpeedUp();

		Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	
}
