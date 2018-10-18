using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class KILL : MonoBehaviour {

	public LevelManager LevelManager;

	// Use this for initialization
	void Start () {
		LevelManager = FindObjectOfType <LevelManager>();
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if(other.name == "Player"){
			LevelManager.RespawnPlayer();
		}
	}
}
