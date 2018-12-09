using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnemyDamage : MonoBehaviour {

	public PlayerHealth PlayerHealth;
	public float Damage = 10f;

	// Use this for initialization
	void Start () {
		PlayerHealth = FindObjectOfType <PlayerHealth>();
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log("Hit");
			if(other.name == "Player") {
				PlayerHealth.Health -= Damage;
			}
		}

	// Update is called once per frame
	void Update () {

	}

}

