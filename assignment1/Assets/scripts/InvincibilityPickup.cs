using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvincibilityPickup : MonoBehaviour {

	public EnemyDamage EnemyDamage;

	// Use this for initialization
	void Start () {
		EnemyDamage = FindObjectOfType <EnemyDamage>();
	}

	void OnTriggerEnter2D (Collider2D Other){
		if  (Other.GetComponent<Rigidbody2D> () == null)
			return;	
		
		EnemyDamage.DamageStop();

		Destroy (gameObject);
	}
}
