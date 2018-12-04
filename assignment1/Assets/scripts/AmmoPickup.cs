using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AmmoPickup : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D Other){
		if  (Other.GetComponent<Rigidbody2D> () == null)
			return;

		Destroy (gameObject);
	}
}
