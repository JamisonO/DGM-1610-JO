using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HealthPickup : MonoBehaviour {

	public float HPtoAdd;
	public PlayerHealth PlayerHealth;

	void Start () {
		PlayerHealth = FindObjectOfType <PlayerHealth>();
	}

	void OnTriggerEnter2D (Collider2D other){
		if(other.name == "Player"){

		PlayerHealth.AddHP (HPtoAdd);

		Destroy (gameObject);
		}
	}
}
