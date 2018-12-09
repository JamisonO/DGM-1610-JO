using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AmmoPickup : MonoBehaviour {

	public float AmmotoAdd;
	public shootfunct shootfunct;

	void Start () {
		shootfunct = FindObjectOfType <shootfunct>();
	}

	void OnTriggerEnter2D (Collider2D other){
		if(other.name == "Player"){

		shootfunct.AddAmmo (AmmotoAdd);

		Destroy (gameObject);
		}
	}
}
