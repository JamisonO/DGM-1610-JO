using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvincibilityPickup : MonoBehaviour {

	public PlayerHealth PlayerHealth;

	// Use this for initialization
	void Start () {
		PlayerHealth = FindObjectOfType <PlayerHealth>();
	}

	void OnTriggerEnter2D (Collider2D other){
		if(other.name == "Player"){

		PlayerHealth.DamageStop();

		Destroy (gameObject);
		}
	}
}
