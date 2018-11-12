using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class KILL : MonoBehaviour {

	public LevelManager LevelManager;
	private int health = 50;

	// Use this for initialization
	void Start () {
		LevelManager = FindObjectOfType <LevelManager>();
	}

	void OnTriggerEnter2D(Collider2D other){
			if(other.name == "Player") {
				health = health - 5;
			}
		}

	// Update is called once per frame
	void Update () {
		switch (health){

		case 50:
			//animation 3
			Debug.Log("Slightly Injured");
			break;
		case 20:
			//animation 2
			Debug.Log("Fairly Injured");
			break;
		case 5:
			//animation 1
			Debug.Log("Critically Injured");
			break;
		default:
			//Dead
			LevelManager.RespawnPlayer();
			Debug.Log("Dead");
			break;
		}
	}

}

