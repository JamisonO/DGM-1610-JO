using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CoinPickup : MonoBehaviour {

	public int PointsToAdd;

	void OnTriggerEnter2D (Collider2D other){
		if(other.name == "Player"){

		ScoreManager.AddPoints (PointsToAdd);

		Destroy (gameObject);
		}
	}	
}


