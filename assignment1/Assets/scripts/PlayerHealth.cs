﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	public Slider Bar;
	public float Health = 100f;
	public LevelManager LevelManager;

	// Use this for initialization
	void Start () {
		LevelManager = FindObjectOfType <LevelManager>();
	}

	// Update is called once per frame
	void Update () {

		//Updates health bar slider with current health
		Bar.value = Health;

		if(Health == 0f) {
			LevelManager.RespawnPlayer();
		}
	}
}
