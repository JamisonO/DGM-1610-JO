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

	void OnTriggerEnter2D (Collider2D Other){
		if  (Other.GetComponent<Rigidbody2D> () == null)
			return;

		shootfunct.AddAmmo (AmmotoAdd);

		Destroy (gameObject);
	}
}
