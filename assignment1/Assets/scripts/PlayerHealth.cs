using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	public Slider Bar;
	public float Health = 100f;
	private float CurrentHealth;
	public LevelManager LevelManager;

	// Use this for initialization
	void Start () {
		LevelManager = FindObjectOfType <LevelManager>();
		CurrentHealth = Health;
	}

	// Update is called once per frame
	void Update () {

		//Updates health bar slider with current health
		Bar.value = Health;

		if(Health == 0f){
			LevelManager.RespawnPlayer();
		}

		if (Health >= 100){
			Health = 100;
		}
	}

	//HP addition for HealthPickup

	public void AddHP (float HPtoAdd){
		
		Health += HPtoAdd;

	}

	// coroutine for invincibility pickup

	public void DamageStop()
    {
        StartCoroutine("DamageStopCo");
    }

	public IEnumerator DamageStopCo()
    {
		 CurrentHealth = Health;
		 Bar.value = 100;
		 enabled = false;
         yield return new WaitForSeconds(10.0f);
		 enabled = true;
		 Health = CurrentHealth;
		 Bar.value = Health;
	}	
}
