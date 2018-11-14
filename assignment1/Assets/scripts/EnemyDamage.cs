using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnemyDamage : MonoBehaviour {

	public PlayerHealth PlayerHealth;

	// Use this for initialization
	void Start () {
		PlayerHealth = FindObjectOfType <PlayerHealth>();
	}

	void OnTriggerEnter2D(Collider2D other){
			if(other.name == "Player") {
				PlayerHealth.Health -= 10;
			}
		}

	// Update is called once per frame
	void Update () {

	}
	

}

