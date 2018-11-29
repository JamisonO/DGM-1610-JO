using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	public float Health = 100f;
	public LevelManager LevelManager;

	// Use this for initialization
	void Start () {
		LevelManager = FindObjectOfType <LevelManager>();
	}

	// Update is called once per frame
	void Update () {
		if(Health == 0f) {
			LevelManager.RespawnPlayer();
		}
	}
}
