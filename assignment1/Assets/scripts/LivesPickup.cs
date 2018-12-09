using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesPickup : MonoBehaviour {

	public float LifetoAdd;
	public LevelManager LevelManager;

	// Use this for initialization
	void Start () {
		LevelManager = FindObjectOfType <LevelManager>();
	}

	void OnTriggerEnter2D (Collider2D other){
		if(other.name == "Player"){

		LevelManager.AddLife (LifetoAdd);

		Destroy (gameObject);
		}
	}

}
